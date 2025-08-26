using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.TicketDTO
{
    public class TicketGet
    {
        public int Id { get; set; }
        public int numSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public TicketGet(Ticket ticket)
        {
            Id = ticket.Id;
            numSeats = ticket.numSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
    }
}
