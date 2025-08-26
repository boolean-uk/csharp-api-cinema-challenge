using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var ticket = app.MapGroup("customers/");

            ticket.MapGet("{cId}/screenings{sId}", GetAll);
            ticket.MapPost("{cId}/screenings{sId}", Create);
        }

        private static TicketGet TicketToTicketGet(Ticket t)
        {
            TicketGet ticketGet = new TicketGet() { Id = t.Id, NumSeats = t.NumSeats, CreatedAt = t.CreatedAt, UpdatedAt = t.UpdatedAt };
            return ticketGet;
        }

        [Authorize("Admin,User")]
        public static async Task<IResult> GetAll(IRepository<Ticket> ticketRepo, int cId, int sId)
        {
            //List<Ticket> results = new List<Ticket>();
            var tickets = await ticketRepo.GetAll();
            var results = tickets.Where(t => t.CustomerId == cId && t.ScreeningId == sId).ToList();
            var resultsShow = new List<TicketGet>();
            foreach (var result in results) 
            { 
                resultsShow.Add(TicketToTicketGet(result));
            }
            return TypedResults.Ok(resultsShow);
        }

        [Authorize(Roles = "User")]
        public static async Task<IResult> Create(IRepository<Ticket> ticketRepo, int cId, int sId, TicketPost t)
        {
            DateTime time = DateTime.UtcNow.ToUniversalTime();

            Ticket ticket = new Ticket() 
            {
                NumSeats = t.NumSeats,
                CustomerId = cId,
                ScreeningId = sId,
                CreatedAt = time,
                UpdatedAt = time
            };
            await ticketRepo.Insert(ticket);
            return TypedResults.Ok(TicketToTicketGet(ticket));
        }
    }
}
