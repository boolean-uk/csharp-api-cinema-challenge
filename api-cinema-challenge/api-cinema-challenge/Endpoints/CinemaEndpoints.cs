using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {

        public static void ConfigureCinemaEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema/movies");

            cinemaGroup.MapPost("/{id}/screenings", CreateScreening);
            cinemaGroup.MapGet("/{id}/screenings", GetScreenings);

            cinemaGroup.MapPost("/customers/{customerId}/screenings/{screeningId}", CreateTicket);
            cinemaGroup.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);

        }


        /// SCREENINGS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(int id, IRepository repository)
        { 

            var screenings = await repository.GetScreenings(id);

            List<Object> fstatus = new List<Object>();

            foreach (Screening screening in screenings)
            {
                var scr = new ScreeningDTO(screening);
                fstatus.Add(scr);
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  // [AsParameters]
        public static async Task<IResult> CreateScreening(int id, CreateScreeningPayload payload, IRepository repository)
        {

            if (payload.screenNumber <= 0 || payload.capacity <= 0 || id <= 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (ValidationHelpers.correctDateTimeFormat(payload.startsAt) == false) 
            {
                return Results.BadRequest("Give datetime in the correct format: YYYY-MM-DD HH:MM:SS");
            }
        
            Screening? screening = await repository.CreateScreening(
                payload.screenNumber,
                payload.capacity,
                DateTime.Parse(payload.startsAt).ToUniversalTime(),
            id);


            if (screening == null)
            {
                return Results.BadRequest("Screening could not be created!");
            }

            repository.SaveChanges();

            ScreeningDTO screeningDTO = new ScreeningDTO(screening);
            StatusSingleDto sto = new StatusSingleDto( screeningDTO );

            return TypedResults.Created($"/screenings{screening.Id}", sto);
        }




        //{customerId}/screenings/{screeningId}
        /// TICKETS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository repository)
        {

            var tickets = await repository.GetTickets(customerId, screeningId);

            List<Object> fstatus = new List<Object>();

            foreach (Ticket t in tickets)
            {
                var tic = new TicketDTO(t);
                fstatus.Add(tic);
               
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }


        // {customerId}/screenings/{screeningId}
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  // [AsParameters]
        public static async Task<IResult> CreateTicket(int customerId, int screeningId, CreateTicketPayload payload, IRepository repository)
        {

            if (payload.numSeats <= 0)
            {
                return Results.BadRequest("Non-zero positive seat amount is required");
            }


            Ticket? ticket = await repository.CreateTicket(customerId, screeningId, payload.numSeats);

            if (ticket == null)
            {
                return Results.BadRequest("Customer or screening does not exist!");
            }

            repository.SaveChanges();

            TicketDTO tdo = new TicketDTO(ticket);

            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", new StatusSingleDto( tdo ));
        }
    }
}
