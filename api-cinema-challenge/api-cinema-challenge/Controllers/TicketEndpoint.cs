using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/tickets", GetTickets);
            cinemaGroup.MapGet("/ticket/{id}", GetTicketById);
            cinemaGroup.MapPost("/ticket", CreateTicket);
            cinemaGroup.MapPut("/ticket/{id}", UpdateTicket);
            cinemaGroup.MapDelete("/ticket/{id}", DeleteTicket);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, IService service)
        {
            var data = await repository.Get();
            var output = await service.MultipleToDto<Ticket, TicketDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTicketById(IRepository<Ticket> repository, IService service, int id)
        {
            var data = await repository.GetById(id);
            if (data == null) { return TypedResults.NotFound("Ticket not found"); }
            var output = await service.SingleToDto<Ticket, TicketDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, IService service, TicketPost input)
        {
            if (repository.Get().Result.Any(x => x.ScreeningId == input.ScreeningId && x.SeatId == input.SeatId))
            {
                return TypedResults.BadRequest("This seat is already occupied for this screening");
            }
            Ticket ticket = new Ticket()
            {
                ScreeningId = input.ScreeningId,
                SeatId = input.SeatId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var data = await repository.Create(ticket, x => x.Screening, x => x.Seat);
            var output = await service.SingleToDto<Ticket, TicketDto>(data);
            return TypedResults.Created($"/{data.Id}", output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateTicket(IRepository<Ticket> repository, IService service, int id, TicketPut input)
        {
            Ticket ticket = await repository.GetById(id);
            if (repository.Get().Result.Any(x => x.ScreeningId == input.ScreeningId && x.SeatId == input.SeatId))
            {
                return TypedResults.BadRequest("This seat is already occupied for this screening");
            } else if (ticket.Screening.HallId != ticket.Seat.HallId)
            {
                return TypedResults.BadRequest("The seat must be in the same hall as the screening.");
            }
            if (ticket == null) { return TypedResults.NotFound("Ticket not found"); }
            ticket.SeatId = input.SeatId;
            ticket.ScreeningId = input.ScreeningId;
            ticket.UpdatedAt = DateTime.UtcNow;
            var data = await repository.Update(ticket);
            var output = await service.SingleToDto<Ticket, TicketDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteTicket(IRepository<Ticket> repository, IService service, int id)
        {
            if (await repository.GetById(id) == null) { return TypedResults.NotFound("Ticket not found"); }
            var data = await repository.Delete(id);
            var output = await service.SingleToDto<Ticket, TicketDto>(data);
            return TypedResults.Ok(output);
        }
    }
}