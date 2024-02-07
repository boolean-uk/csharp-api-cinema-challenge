using api_cinema_challenge.Model;
using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("ticket");

            ticketGroup.MapGet("/tickets" , GetTickets);
            ticketGroup.MapGet("/tickets/{id}" , GetTicketById);
            ticketGroup.MapPost("/tickets" , CreateTicket);
            ticketGroup.MapDelete("/tickets/{id}" , DeleteTicket);
            ticketGroup.MapPut("/tickets/{id}" , UpdateTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(ITicketRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllTickets());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTicketById(ITicketRepository repository , int id)
        {
            var ticket = await repository.GetTicket(id);
            if(ticket == null)
            {
                return Results.NotFound($"Ticket with ID {id} not found.");
            }
            return Results.Ok(ticket);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(ITicketRepository repository , TicketDto ticketDto)
        {
            var ticket = new Ticket
            {
                SeatId = ticketDto.SeatId ,
                ScreeningId = ticketDto.ScreeningId
            };

            ticket = await repository.CreateTicket(ticket);
            return Results.Created($"/tickets/{ticket.Id}" , ticket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteTicket(ITicketRepository repository , int id)
        {
            var ticket = await repository.DeleteTicket(id);
            if(ticket == null)
            {
                return Results.NotFound($"Ticket with ID {id} not found.");
            }
            return Results.Ok(ticket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateTicket(ITicketRepository repository , int id , TicketDto ticketDto)
        {
            var ticket = new Ticket
            {
                SeatId = ticketDto.SeatId ,
                ScreeningId = ticketDto.ScreeningId
            };

            ticket = await repository.UpdateTicket(id , ticket);
            if(ticket == null)
            {
                return Results.NotFound($"Ticket with ID {id} not found.");
            }
            return Results.Ok(ticket);
        }
    }
}
