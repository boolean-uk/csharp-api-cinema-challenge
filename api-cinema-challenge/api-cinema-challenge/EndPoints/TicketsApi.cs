using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketsApi
    {
        public static void ConfigureTicketsApi(this WebApplication app)
        {
            app.MapPost("/customers/{customerId}/screenings/{screeningId}", BookTicket);
            app.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> BookTicket(int customerId, int screeningId, TicketPost model, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Ticket ticket = new Ticket()
                    {
                        CustomerId = customerId,
                        ScreeningId = screeningId,
                        NumSeats = model.NumSeats,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };

                    service.BookTicket(ticket);

                    Payload<Ticket> payload = new Payload<Ticket>()
                    {
                        data = ticket
                    };

                    return Results.Created($"/customers/{customerId}/screenings/{screeningId}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(int customerId, int screeningId, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Ticket>> payload = new Payload<IEnumerable<Ticket>>()
                    {
                        data = service.GetAllTickets().Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId).ToList()
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
