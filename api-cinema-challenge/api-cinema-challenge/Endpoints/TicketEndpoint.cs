
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("tickets");

            ticketGroup.MapPost("/BookATicket/{customerId}/screening/{screeningId}", BookATicket);
            ticketGroup.MapGet("/GetAllTickets/{customerId}/screening/{screeningId}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> BookATicket(IRepository repository, int numberOfSeats, int customerId, int screeningId)
        {
            try
            {
                return TypedResults.Ok(await repository.BookTicket(numberOfSeats, customerId, screeningId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository repository, int customerId, int screeningId)
        {
            try
            {
                return TypedResults.Ok(await repository.GetTickets(customerId, screeningId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
