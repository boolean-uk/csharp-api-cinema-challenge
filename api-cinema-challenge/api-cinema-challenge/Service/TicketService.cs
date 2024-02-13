using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Service
{
    public static class TicketService
    {
        public static Ticket toTicket(TicketDto ticketDto, int customerId, int screeningId)
        {
            return new Ticket()
            {
                NumSeats = ticketDto.NumSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        public static Ticket updateTicket(Ticket ticket, TicketDto ticketDto)
        {
            ticket.NumSeats = ticketDto.NumSeats;
            ticket.UpdatedAt = DateTime.UtcNow;

            return ticket;
        }
    }
}
