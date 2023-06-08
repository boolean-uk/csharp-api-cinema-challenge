using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketAPI(this WebApplication app)
        {
           

            app.MapGet("/ticket", GetTickets);
            app.MapPost("/ticket", CreateTicket);




        }

        private static async Task<IResult> CreateTicket(ICinemaRepo repo, Ticket ticket)
        {
            try
            {
                return Results.Ok(repo.CreateTicket(ticket));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> GetTickets(ICinemaRepo repo)
        {
            try
            {
                return Results.Ok(repo.GetallTicket());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
