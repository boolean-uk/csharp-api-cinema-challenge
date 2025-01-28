using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class TicketEndpoints
{
    public static void ConfigureTicketEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/customers/{cid}/screenings/{mid}");

        group.MapGet("/", GetTickets);
        group.MapPost("/", CreateTicket);
    }
    
    [ProducesResponseType(typeof(BaseResponse<IEnumerable<TicketResponse>>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetTickets(IRepository<Ticket> repository, IMapper mapper, int cid, int mid)
    {
        var tickets = await repository.GetAll(t => t.CustomerId == cid && t.ScreeningId == mid);
        var response = new BaseResponse<IEnumerable<TicketResponse>>(
            Consts.SuccessStatus,
            mapper.Map<IEnumerable<TicketResponse>>(tickets)
        );

        return TypedResults.Ok(response);
    }
    
    [ProducesResponseType(typeof(BaseResponse<TicketResponse>), StatusCodes.Status201Created)]
    public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, IMapper mapper, int cid, int mid, [FromBody] TicketPost body)
    {
        var ticket = mapper.Map<Ticket>(body);
        ticket.CustomerId = cid;
        ticket.ScreeningId = mid;
        await repository.Add(ticket);
        var response = new BaseResponse<TicketResponse>(
            Consts.SuccessStatus,
            mapper.Map<TicketResponse>(ticket)
        );

        return TypedResults.Created("/customers/" + cid + "/screenings/" + mid + "/tickets/" + ticket.Id, response);
    }
}