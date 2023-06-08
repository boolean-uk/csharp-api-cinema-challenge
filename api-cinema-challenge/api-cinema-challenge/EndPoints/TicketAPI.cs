using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketAPI
    {
        public static void ConfigureTicketAPI(this WebApplication app)
        {
            app.MapGet("/tickets", GetTickets);
            app.MapPost("/tickets", AddTicket);
        }

        private static async Task<IResult> GetTickets(ITicketRepository context)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(context.GetTickets());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddTicket(Ticket ticket, ITicketRepository context)
        {
            try
            {
                if (context.AddTicket(ticket)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
