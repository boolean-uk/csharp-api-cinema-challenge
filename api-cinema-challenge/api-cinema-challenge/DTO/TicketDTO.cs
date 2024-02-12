using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public TicketDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumberOfSeats = ticket.NumberOfSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
