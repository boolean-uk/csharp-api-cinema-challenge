using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            app.MapPost("/ticket/{customerId}/screenings/{screeningId}", CreateTicket);
            app.MapGet("/ticket/{customerId}/screenings/{screeningId}", GetTickets);
            app.MapGet("/ticket/customer/{customerId}", GetTicketsByCustomer);
            app.MapGet("/ticket/screening/{screeningId}", GetTicketsByScreening);
        }

        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, IMovieRepository movieRepository, ICustomerRepository customerRepository, int customerId, int screeningId, TicketPayload payload)
        {
            Customer? customer = await customerRepository.GetCustomerByID(customerId);
            if (customer is null) return TypedResults.BadRequest("The customer doesn't exist");
            Screening? screening = await movieRepository.GetScreeningByID(screeningId);
            if (screening is null) return TypedResults.BadRequest("The screening doesn't exist");

            Ticket result = await ticketRepository.CreateTicket(payload.NumSeats, customer, screening);
            if (result is null) return TypedResults.BadRequest("The customer or the screening doesn't exist");
            return TypedResults.Created("", new Payload<Ticket>() { data = result});
        }

        public static async Task<IResult> GetTickets(ITicketRepository ticketRepository, IMovieRepository movieRepository, ICustomerRepository customerRepository, int customerId, int screeningId)
        {
            Customer? customer = await customerRepository.GetCustomerByID(customerId);
            if (customer is null) return TypedResults.BadRequest("The customer doesn't exist");
            Screening? screening = await movieRepository.GetScreeningByID(screeningId);
            if (screening is null) return TypedResults.BadRequest("The screening doesn't exist");
            var result = await ticketRepository.GetTickets(customerId, screeningId);
            return TypedResults.Created("", new Payload<IEnumerable<Ticket>>() { data = result});
        }

        public static async Task<IResult> GetTicketsByCustomer(ITicketRepository ticketRepository, ICustomerRepository customerRepository, int customerId)
        {
            Customer? customer = await customerRepository.GetCustomerByID(customerId);
            if (customer is null) return TypedResults.BadRequest("The customer doesn't exist");
            var result = await ticketRepository.GetTicketsbyCustomer(customer);
            return TypedResults.Created("", new Payload<IEnumerable<Ticket>>() { data = result });
        }

        public static async Task<IResult> GetTicketsByScreening(ITicketRepository ticketRepository, IMovieRepository movieRepository, int screeningId)
        {
            Screening? screening = await movieRepository.GetScreeningByID(screeningId);
            if (screening is null) return TypedResults.BadRequest("The screening doesn't exist");
            var result = await ticketRepository.GetTicketsbyScreening(screening);
            return TypedResults.Created("", new Payload<IEnumerable<Ticket>>() { data = result });
        }


    }
}
