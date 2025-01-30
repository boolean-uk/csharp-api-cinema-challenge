using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.SpecificRepositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            var tickets = app.MapGroup("/customers/{customerId}/screenings/{screeningId}");

            tickets.MapPost("/", BookTicket);
            tickets.MapGet("/", GetAllTicketsForCustomer);
        }

        // Book a Ticket for a Customer and Screening
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> BookTicket(int customerId, int screeningId, Ticket ticket, ITicketRepository ticketRepository)
        {
            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;
            await ticketRepository.AddAsync(ticket);
            return TypedResults.Created($"/customers/{customerId}/screenings/{screeningId}", new { status = "success", data = ticket });
        }

        // Get all Tickets for a Customer and Screening
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllTicketsForCustomer(int customerId, int screeningId, ITicketRepository ticketRepository)
        {
            var tickets = await ticketRepository.GetTicketsByCustomerAsync(customerId);
            return TypedResults.Ok(new { status = "success", data = tickets });
        }
    }
}
