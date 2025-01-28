
using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class TicketsEndpoint
    {
        public static void ConfigureTicketsEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("/customers/{customerId}/screenings/{screeningId}");
            ticketGroup.MapPost("/", BookATicket);
            ticketGroup.MapGet("/", GetAllTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> BookATicket(HttpContext context, IRepository<Tickets> repo, int customerId, int screeningsId, Create_Ticket dto)
        {
            var ticket = Create_Ticket.create(dto, screeningsId, customerId);

            var entity = await repo.CreateEntry(ticket);

            return TypedResults.Created(context.Get_endpointUrl(entity.Id), Get_Ticket.toPayload(entity));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllTickets( IRepository<Tickets> repo, int customerId, int screeningId)
        {

            var entries = await repo.GetEntries(x => x.Where(x => x.ScreeningId == screeningId && x.CustomerId == customerId));
            return TypedResults.Ok(Get_Ticket.toPayload(entries));
        }
        

    }
}
