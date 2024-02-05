using System.Net.Http.Headers;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");
            cinema.MapPost("customers/{customers_id}/screenings/{screening_id}", CreateTicket);
            cinema.MapGet("customers/{customers_id}/screenings/{screening_id}", GetAllTicketsByCustomerAndScreeningID);
        }

        public static async Task<IResult> CreateTicket(int customerId, int screeningId, CreateTicketPayload payload, ICinemaRepository repository)
        {
            if (payload.SeatNumber <= 0)
            {
                return TypedResults.BadRequest("SeatNumber must be greater than 0");
            }
            if (payload.CustomerId <= 0)
            {
                return TypedResults.BadRequest("CustomerId must be greater than 0");
            }
            if (payload.ScreeningId <= 0)
            {
                return TypedResults.BadRequest("ScreeningId must be greater than 0");
            }
            Ticket? ticket = await repository.CreateTicket(payload.SeatNumber, payload.CustomerId, payload.ScreeningId, payload);
            return TypedResults.Ok(new TicketResponseDTO("success", ticket));
        }

        public static async Task<IResult> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId, ICinemaRepository repository)
        {
            var tickets = await repository.GetAllTicketsByCustomerAndScreeningID(customerId, screeningId);
            if (tickets.Count == 0)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new TicketListResponseDTO("success", tickets));
        }

    }
}