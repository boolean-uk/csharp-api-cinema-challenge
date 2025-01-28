using api_cinema_challenge.DTO.Requests;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var t = app.MapGroup("/customers/{customerId}/screenings/{screeningId}");

            t.MapPost("/", BookTicket);
            t.MapGet("/", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> BookTicket(IRepository<Ticket> ticketRepository, IMapper mapper, int customerId, int screeningId, TicketRequestDto ticketDto)
        {
            var ticket = mapper.Map<Ticket>(ticketDto);
            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;
            var createdTicket = await ticketRepository.Insert(ticket);
            await ticketRepository.Save();
            var ticketResponse = mapper.Map<TicketResponseDto>(createdTicket);
            var response = new Payload { Status = "success", Data = ticketResponse };
            return TypedResults.Created($"/customers/{customerId}/screenings/{screeningId}/tickets/{createdTicket.Id}", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(IRepository<Ticket> repository, IMapper mapper, int customerId, int screeningId)
        {
            var allTickets = await repository.Get();
            var tickets = allTickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId);
            var ticketDtos = mapper.Map<IEnumerable<TicketResponseDto>>(tickets);
            var response = new Payload { Status = "success", Data = ticketDtos };
            return TypedResults.Ok(response);
        }

    }
}
