using api_cinema_challenge.Models.TicketModels;

namespace api_cinema_challenge.Services
{
    public static class TicketDtoManager
    {
        public static OutputTicket Convert(Ticket ticket)
        {
            return new OutputTicket
            {
                Id = ticket.Id,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt,
                NumSeats = ticket.NumSeats
            };
        }

        public static IEnumerable<OutputTicket> Convert(IEnumerable<Ticket> tickets)
        {
            return tickets.Select(Convert);
        }

        public static Ticket Convert(InputTicket ticket)
        {
            return new Ticket
            {
                NumSeats = ticket.NumSeats
            };
        }
    }
}
