using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {

        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("ticket");

            ticketGroup.MapPost("/", CreateTicket);
            ticketGroup.MapGet("/", GetAllTickets);


        }


        public static async Task<IResult> CreateTicket([FromBody] TicketPayload payload, 
                                  [FromServices] IRepository repository, int customerId, int screeningId)
        {
            Ticket? ticket = await repository.CreateTicket(payload.NumSeat,customerId, screeningId, DateTime.UtcNow);
            if (ticket == null)
            {
                return Results.BadRequest("Failed to create a ticket.");
            }

            repository.SaveChanges();

            TicketDto ticketDto = new TicketDto(ticket);

            return TypedResults.Created($"/Ticket {ticket.Id}", ticketDto);
        }


        public static async Task<IResult> GetAllTickets(IRepository repository)
        {
            var tickets = await repository.GetAllTickets();

            List<Object> result = new List<Object>();
            foreach (Ticket ticket in tickets)
            {
                var addTicket = new TicketDto(ticket);
                result.Add(addTicket);
            }

            return TypedResults.Ok(result);
        }
    }
}
