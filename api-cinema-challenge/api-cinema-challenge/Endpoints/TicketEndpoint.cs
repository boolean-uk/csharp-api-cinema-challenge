using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.Payload;
using api_cinema_challenge.Models.Response;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app) 
        {
            var ticket = app.MapGroup("/customers");
            ticket.MapPost("/{customerid}/screenings/{screeningid}", CreateTicket);
            ticket.MapGet("/{customerid}/screenings/{screeningid}", GetTickets);
        }

        public static async Task<IResult> CreateTicket(IRepository<Ticket, TicketPayload> repo, int customerid, int screeningid, TicketPayload payload)
        {
            TicketRepository ticketRepository = (TicketRepository) repo;
            Ticket ticket = await ticketRepository.CreateTicket(payload, customerid, screeningid);
            TicketDTO DTO = new TicketDTO()
            {
                Id = ticket.Id,
                NumSeats = ticket.NumSeats,
                CreatedAt = ticket.CreatedAT,
                UpdatedAt = ticket.UpdatedAT,
            };
            return TypedResults.Created("/", new Response("success", DTO)); 
        }

        public static async Task<IResult> GetTickets(IRepository<Ticket, TicketPayload> repo, int customerid, int screeningid)
        {
            TicketRepository ticketRepository = (TicketRepository) repo;
            IEnumerable<Ticket> tickets = await ticketRepository.GetTickets(customerid, screeningid);

            IEnumerable<TicketDTO> DTOS = tickets.Select(t => new TicketDTO()
            {
                Id = t.Id,
                NumSeats = t.NumSeats,
                CreatedAt = t.CreatedAT,
                UpdatedAt = t.UpdatedAT
            });
            return TypedResults.Ok(new Response("success", DTOS));
        }
    }
}
