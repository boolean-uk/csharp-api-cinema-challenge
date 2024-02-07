using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Models.TransferModels.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketsEndpoint
    {
        public static void ConfigureTicketsEndpoint(this WebApplication app) 
        {
            var ticketGroup = app.MapGroup("tickets/");

            ticketGroup.MapGet("/", GetTickets);
            ticketGroup.MapGet("/{id}", GetTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTickets(IRepository<Ticket> repo)
        {
            IEnumerable<Ticket> tickets = await repo.GetAllIncluding();

            IEnumerable<TicketWithCustomerAndMovieDTO> ticketsOut = tickets.OrderBy(t => t.TicketId).Select(t => new TicketWithCustomerAndMovieDTO(t.TicketId, t.NumberOfSeats, t.CreatedAt, t.UpdatedAt, t.Customer, t.Screening));
            Payload<IEnumerable<TicketWithCustomerAndMovieDTO>> payload = new Payload<IEnumerable<TicketWithCustomerAndMovieDTO>>(ticketsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicket(IRepository<Ticket> repo, int id)
        {
            Ticket? ticket = await repo.GetIncluding(id, "TicketId", (t => t.Customer));
            if (ticket == null) 
            {
                return TypedResults.NotFound($"No ticket with the provided ID {id} could be found.");
            }

            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.NumberOfSeats, ticket.CreatedAt, ticket.UpdatedAt);
            Payload<TicketDTO> payload = new Payload<TicketDTO>(ticketOut);
            return TypedResults.Ok(payload);
        }
    }
}
