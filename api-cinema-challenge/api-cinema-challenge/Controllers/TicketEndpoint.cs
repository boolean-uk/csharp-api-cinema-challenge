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

            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", Ticket.ToDTO(ticket));
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

            return TypedResults.Created($"/{customerId}/screenings/", Ticket.ToDTO(tickets));
        }
    }
}
