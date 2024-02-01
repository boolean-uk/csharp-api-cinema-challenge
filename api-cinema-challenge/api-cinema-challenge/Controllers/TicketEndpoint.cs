using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            app.MapPost("/customers/{customerId}/screenings/{screeningId}", CreateTicket);
            app.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);
        }

        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, int customerId, int screeningId, TicketPayload payload)
        {
            Ticket? result = await ticketRepository.CreateTicket(payload.NumSeats, customerId, screeningId);
            if (result is null) return TypedResults.BadRequest("The customer or the screening doesn't exist");
            return TypedResults.Created("", new TicketOutput("success", result));
        }

        public static async Task<IResult> GetTickets(ITicketRepository ticketRepository, int customerId, int screeningId)
        {
            var result = await ticketRepository.GetTickets(customerId, screeningId);
            if (result is null) return TypedResults.BadRequest("The customer or the screening doesn't exist");
            return TypedResults.Created("", new TicketListOutput("success", result));
        }
    }
}
