using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public record TicketPostPayload(int numSeats);

    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("customers");

            ticketGroup.MapGet("/{customerId}/screenings{screeningId}", GetAllTickets);
            ticketGroup.MapPost("/{customerId}/screenings{screeningId}", BookATicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllTickets(ITicketRepository repository, int customerId, int screeningId)
        {
            List<Ticket?> tickets = await repository.GetTickets(customerId, screeningId);
            if (tickets == null || tickets.Count == 0)
                return Results.BadRequest("No tickets for that movie");

            return TypedResults.Ok(TicketResponseDTO.FromRepository(tickets));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> BookATicket(ITicketRepository repository, ICustomerRepository customerRep, IScreeningRepository screenRep, TicketPostPayload payload, int customerId, int screeningId)
        {
            //Checking id
            Customer? customer = await customerRep.GetCustomer(customerId);
            if (customer == null)
                return Results.NotFound("Customer ID out of scope");

            Screening? screening = await screenRep.GetScreening(screeningId);
            if (screening == null)
                return Results.NotFound("Screening ID out of scope");

            //Books the ticket
            var ticket = await repository.BookATicket(payload.numSeats, customerId, screeningId);
            if (ticket == null)
                return Results.BadRequest("Could not book that ticket");

            TicketResponseDTO tick = TicketResponseDTO.FromARepository(ticket);
            return TypedResults.Created($"/tickets{tick.Status} {tick.Datas}", tick);
        }
    }
}
