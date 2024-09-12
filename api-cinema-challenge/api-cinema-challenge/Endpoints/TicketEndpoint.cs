using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModelsTicket;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");

            tickets.MapPost("/Create{customerId}|{screeningId}", CreateTicket);
            tickets.MapGet("/GetAll{customerId}|{screeningId}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository repository, InputTicketDTO data, int customerId, int screeningId)
        {
            try
            {
                //Create a ticket
                Ticket ticket = new Ticket()
                {
                    NumSeats = data.numSeats,
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    CreatedAt = DateTime.UtcNow
                };
                ticket.UpdatedAt = ticket.CreatedAt;
                var result = await repository.AddTicket(ticket);

                //Response
                return TypedResults.Created($"http://localhost:7195/tickets/{result.data.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository repository, int customerId, int screeningId)
        {
            try
            {
                var result = await repository.GetTickets(customerId, screeningId);

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
