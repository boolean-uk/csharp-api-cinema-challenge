using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapGet("/movies/{id}/screenings/{name}", GetTickets);
            app.MapPost("/movies/{id}/screenings/{thisid}", AddTicket);
        }

        public static async Task<IResult> GetTickets(iRepositoryCinema repository)
        {
            try
            {
                var tickets = repository.GetTickets();
                return tickets != null ? Results.Ok(tickets) : Results.Problem("There are no tickets yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddTicket(iRepositoryCinema repository, Ticket ticket)
        {
            try
            {
                var item = repository.AddTicket(ticket);
                return item != null ? Results.Created("https://localhost:7174/screenings", ticket) : Results.Problem("There is no ticket to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
