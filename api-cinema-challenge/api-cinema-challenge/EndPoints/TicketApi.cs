using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapGet("/tickets", GetTickets);
            app.MapPost("tickets", InsertTicket);
        }

        private static async Task<IResult> GetTickets(ICinemaRepository repo)
        {
            try
            {
                var tickets = repo.GetTickets();
                return tickets != null ? Results.Ok(tickets) : Results.NoContent();
            }

            catch (Exception ex) 
            {
                return Results.Problem(ex.Message);
            }
            
        }

        private static async Task<IResult> InsertTicket(Ticket ticket, ICinemaRepository repo)
        {
            try
            {
                var addedTicket = repo.AddTicket(ticket);
                return ticket != null ? Results.Created("https://localhost:7195/tickets", ticket) : Results.NoContent();
            }

            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
