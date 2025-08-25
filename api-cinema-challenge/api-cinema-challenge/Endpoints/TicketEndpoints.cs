using api_cinema_challenge.DataTransfer.Requests;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var screenings = app.MapGroup("/tickets");

            screenings.MapPost("/", Create);
            screenings.MapGet("/", GetAll);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Ticket> repository, TicketPostRequest ticket, int customerId, int screeningId)
        {
            var newTicket = new Ticket()
            {
                NumSeats = ticket.NumSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            await repository.Create(newTicket);
            return TypedResults.Created($"/{newTicket.Id}", newTicket);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Ticket> repository)
        {
            var entities = await repository.GetAll();
            List<Object> results = new List<Object>();

            foreach (var entity in entities)
            {
                results.Add(new
                {
                    NumSeats = entity.NumSeats,
                    CustomerId = entity.CustomerId,
                    ScreeningId = entity.ScreeningId,
                });
            }

            return TypedResults.Ok(results);
        }
    }
}
