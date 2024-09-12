using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Extensions
{
    public static class TicketExtensions
    {
        public static Ticket ToTicket(this TicketPostmodel ticketPost, int customerId, int screeningId)
        {
            return new Ticket
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = ticketPost.NumSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
        }

        public static TicketDTO ToTicketDTO(this Ticket ticket) 
        {
            return new TicketDTO 
            {
                Id = ticket.Id,
                NumSeats = ticket.NumSeats,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt
            };
        }

    }
}
