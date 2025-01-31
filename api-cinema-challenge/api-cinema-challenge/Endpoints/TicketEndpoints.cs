using System;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints;

public static class TicketEndpoints
{
    public static void MapTicketEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/customers/{customerId}/screenings/{screeningId}");

        group.MapPost("/", BookTicket);
        group.MapGet("/", GetAllTickets);
    }

    public static async Task<IResult> BookTicket(int customerId, int screeningId, IRepository<Ticket> ticketRepository, IRepository<Screening> screeningRepository, IMapper mapper, TicketPost ticketPost)
    {
        var screening = await screeningRepository.GetById(screeningId);
        if (screening == null)
        {
            return TypedResults.NotFound($"No screening with id {screeningId} found");
        }

        var ticket = mapper.Map<Ticket>(ticketPost);

        var response = await ticketRepository.Create(ticket);
        return TypedResults.Created("Created", new Payload<TicketDTO>(mapper.Map<TicketDTO>(response)));
    }

    public static async Task<IResult> GetAllTickets(IRepository<Ticket> ticketRepository, IMapper mapper)
    {
        try
        {
            var tickets = await ticketRepository.GetAll();
            return TypedResults.Ok(new Payload<IEnumerable<TicketDTO>>(mapper.Map<IEnumerable<TicketDTO>>(tickets)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }
}
