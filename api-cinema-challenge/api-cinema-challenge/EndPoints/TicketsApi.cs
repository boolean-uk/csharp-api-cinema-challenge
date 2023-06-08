using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketsApi
    {
        public static void ConfigureTicketsApi(this WebApplication app)
        {
            app.MapGet("/tickets", GetTickets);
            app.MapPost("/tickets", AddTicket);
        }

        private static async Task<IResult> AddTicket(Tickets ticket, ICinemaRepository service)
        {
            try
            {
                if (service.AddTicket(ticket)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetTickets(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetTickets());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
