
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


        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllTickets( IRepository<Tickets> repo, int customerId, int screeningsId)
        {
            throw new NotImplementedException();
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> BookATicket(HttpContext context, IRepository<Tickets> repo, int customerId, int screeningsId)
        {
            throw new NotImplementedException();
        }

    }
}
