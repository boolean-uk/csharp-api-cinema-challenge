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

        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, IMovieRepository movieRepository, ICustomerRepository customerRepository, int customerId, int screeningId, TicketPayload payload)
        {
            Customer? customer = await customerRepository.GetCustomerByID(customerId);
            if (customer is null) return TypedResults.BadRequest("The customer doesn't exist");
            Screening? screening = await movieRepository.GetScreeningByID(screeningId);
            if (screening is null) return TypedResults.BadRequest("The screening doesn't exist");

            Ticket result = await ticketRepository.CreateTicket(payload.NumSeats, customer, screening);
            if (result is null) return TypedResults.BadRequest("The customer or the screening doesn't exist");
            return TypedResults.Created("", new TicketOutput("success", result));
        }

        public static async Task<IResult> GetTickets(ITicketRepository ticketRepository, IMovieRepository movieRepository, ICustomerRepository customerRepository, int customerId, int screeningId)
        {
            Customer? customer = await customerRepository.GetCustomerByID(customerId);
            if (customer is null) return TypedResults.BadRequest("The customer doesn't exist");
            Screening? screening = await movieRepository.GetScreeningByID(screeningId);
            if (screening is null) return TypedResults.BadRequest("The screening doesn't exist");
            var result = await ticketRepository.GetTickets(customerId, screeningId);
            return TypedResults.Created("", new TicketListOutput("success", result));
        }
    }
}
