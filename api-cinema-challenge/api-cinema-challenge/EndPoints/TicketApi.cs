using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapPost("/customers/{customerId}/screenings/{screeningId}", CreateTicket);
            app.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);
        }

        /// <summary>Create a new ticket for a particular customer and screening.</summary>
        /// <returns>
        /// Status 201 - Ticket object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateTicket(int customerId, int screeningId, TicketPost t, ITicketRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Ticket ticket = service.CreateTicket(customerId, screeningId, t);
                    Payload<Ticket> payload = new Payload<Ticket>() { data = ticket };
                    return Results.Created($"/customers/{customerId}/screenings/{screeningId}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get a list of every ticket a customer has booked for a screening.</summary>
        /// <returns>
        /// Status 200 - List of all tickets
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(int customerId, int screeningId, ITicketRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Ticket>> payload = new Payload<IEnumerable<Ticket>>()
                    {
                        data = service.GetTickets(customerId, screeningId)
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
