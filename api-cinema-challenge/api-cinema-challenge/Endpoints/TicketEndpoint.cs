using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("/tickets");
            ticketGroup.MapGet("", GetTickets);
            ticketGroup.MapGet("/{id}", GetTicketById);
        }

        private static async Task<IResult> GetTickets(IRepository<Ticket> repo)
        {
            var tickets = await repo.Get();
            return Results.Ok(tickets.Select(ticket => new {
                ticket.Id,
                ticket.NumSeats,
                ticket.CreatedAt,
                ticket.UpdatedAt
            }));
        }

        private static async Task<IResult> GetTicketById(IRepository<Ticket> repo, object screeningId, object customerId)
        {
            var ticket = await repo.GetById(screeningId, customerId);
            if (ticket == null) return Results.NotFound();

            return Results.Ok(new
            {
                new {ticket.Screening,
                ticket.Customer,
                ticket.NumSeats,
                ticket.CreatedAt,
                ticket.UpdatedAt
            });
        }
    }

}
