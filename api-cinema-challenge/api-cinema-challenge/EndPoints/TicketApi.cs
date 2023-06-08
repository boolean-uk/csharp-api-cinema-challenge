using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapGet("/ticekts", GetTickets);
            app.MapPost("/tickets", AddTicket);
        }

        public static async Task<IResult> GetTickets(ICinemaRepository repository)
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

        public static async Task<IResult> AddTicket(int screeningId, Ticket ticket, ICinemaRepository repository)
        {
            try
            {
                var item = repository.AddTicket(ticket, screeningId);
                return item != null ? Results.Created("https://localhost:7174/tickets", item) : Results.Problem("There is no ticket to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
