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
        private static async Task<IResult> CreateTicket(int customerId, int screeningId, Ticket t, ITicketRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Get a list of every ticket a customer has booked for a screening.</summary>
        /// <returns>
        /// Status 200 - List of all tickets
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(int customerId, int screeningId, ITicketRepository service)
        {
            throw new NotImplementedException();
        }
    }
}
