using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapPost("/tickets", BookATicket);
            app.MapGet("/tickets", GetAllTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> BookATicket(int customerid, int screeningid, TicketPost ticket, ITicketRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (ticket == null) return Results.NotFound();
                    Ticket newTicket = new Ticket();
                    newTicket.numSeats = ticket.numSeats;
                    newTicket.createdAt = DateTime.UtcNow;
                    newTicket.updatedAt = DateTime.UtcNow;
                    newTicket.CustomerId = customerid;
                    newTicket.ScreeningId = screeningid;

                    service.AddTicket(newTicket);
                    Payload<Ticket> payload = new Payload<Ticket>()
                    {
                        data = newTicket
                    };

                    return Results.Created($"https://localhost:7195/customer/{newTicket.Id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllTickets(ITicketRepo service, int customerid, int screeningid)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Ticket>> payload = new Payload<IEnumerable<Ticket>>()
                    {
                        data = service.GetAllTickets().Where(t => t.CustomerId == customerid && t.ScreeningId == screeningid).ToList()
                    };
                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
