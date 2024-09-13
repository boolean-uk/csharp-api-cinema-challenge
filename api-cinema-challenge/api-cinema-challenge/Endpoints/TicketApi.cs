using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");
            tickets.MapGet("/{id}", GetTicketsByCustomerId);
            tickets.MapPost("/", CreateTicket);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTicketsByCustomerId(IRepository<Ticket> repository, int customerId)
        {
            Response<IEnumerable<TicketDTO>> response = new();
            var tickets = await repository.GetAllById(customerId);
            var ticketResponse = tickets.Select(t => new TicketDTO(t));
            response.Data = ticketResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, int customerId, int screeningId, TicketPayload model)
        {
            Response<IEnumerable<TicketDTO>> response = new();
            List<TicketDTO> ticketResponse = new();
            var addTicket = new Ticket() { NumSeats = model.NumSeats, CustomerId = customerId, ScreeningId = screeningId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            addTicket = await repository.Add(addTicket);
            ticketResponse.Add(new TicketDTO(addTicket));
            response.Data = ticketResponse;
            return TypedResults.Ok(response);
        }


    }
}
