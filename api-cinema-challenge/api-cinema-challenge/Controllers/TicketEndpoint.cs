using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");

            tickets.MapPost("", AddTicket);
            tickets.MapGet("", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddTicket(ITicketRepository repository, int customerId, int screeningId, int numSeats)
        {
            var ticket = await repository.AddTicket(customerId, screeningId, numSeats);

            if (ticket == null)
            {
                return TypedResults.NotFound($"Customer with id {customerId} or screening with id {screeningId} was not found");
            }

            var ticketResponse = new TicketResponseDTO { Status = "success", Data = ticket.ToDTO() };

            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", ticketResponse);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(ITicketRepository repository, int customerId)
        {
            var tickets = await repository.GetTickets(customerId);

            if (tickets == null)
            {
                return TypedResults.NotFound($"Customer with id {customerId} was not found");
            }
            
            var ticketDTOs = new List<TicketDTO>();
            foreach (var ticket in tickets)
            {
                ticketDTOs.Add(ticket.ToDTO());
            }

            var ticketResponse = new TicketResponseListDTO { Status = "success", Data = ticketDTOs };
            return TypedResults.Created($"/{customerId}/screenings/", ticketResponse);
        }
    }
}
