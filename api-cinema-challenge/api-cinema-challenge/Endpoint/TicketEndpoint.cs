using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoint
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("customer/");

            ticketGroup.MapGet("{customer_id}/screenings/{screening_id}", GetTickets);
            ticketGroup.MapPost("{customer_id}/screenings/{screening_id}", BookTicket);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int customerId, int screeningId)
        {
            var tickets = await repository.Get();

            var requestedTickets = tickets.Where(x => x.CustomerId == customerId && x.ScreeningId == screeningId);

            List<TicketDTO> ticketDTOs = new List<TicketDTO>();
            foreach (var tick in requestedTickets)
            {
                ticketDTOs.Add(new TicketDTO()
                {
                    Id = tick.Id,
                    NumSeats = tick.NumSeats,
                    DateCreated = tick.DateCreated,
                    DateUpdated = tick.DateUpdated
                });
            }

            return TypedResults.Ok(ticketDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> BookTicket(IRepository<Ticket> repository, int customerId, int screeningId, int numSeats)
        {
            Ticket tick = new Ticket()
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = numSeats,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            };

            Ticket acceptedTicket = await repository.Insert(tick);

            TicketDTO tickDTO = new TicketDTO()
            {
                Id = acceptedTicket.Id,
                NumSeats = acceptedTicket.NumSeats,
                DateCreated = acceptedTicket.DateCreated,
                DateUpdated = acceptedTicket.DateUpdated
            };

            return TypedResults.Ok(tickDTO);
        }
    }
}