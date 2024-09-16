using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {

        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("customers/{customerId}/screenings/{screeningId}");

            ticketGroup.MapGet("", GetCustomerTicketsByScreening);
            ticketGroup.MapPost("", BookTicket);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomerTicketsByScreening(ITicketRepository repository, IMapper mapper, int customerId, int screeningId)
        {
            var tickets = await repository.GetCustomerTicketsByScreening(customerId, screeningId);
            var ticketDtos = mapper.Map<IEnumerable<GetTicketDTO>>(tickets);

            var payload = new Payload<IEnumerable<GetTicketDTO>>
            {
                Data = ticketDtos
            };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> BookTicket(ITicketRepository repository, IMapper mapper, int customerId, int screeningId, PostTicketDTO ticketDTO)
        {
            Ticket ticket = mapper.Map<Ticket>(ticketDTO);
            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;
            var createdTicket = await repository.AddTicket(ticket);
            var createdTicketDto = mapper.Map<GetTicketDTO>(createdTicket);

            var payload = new Payload<GetTicketDTO>
            {
                Data = createdTicketDto
            };

            return TypedResults.Ok(payload);
        }

    }
}
