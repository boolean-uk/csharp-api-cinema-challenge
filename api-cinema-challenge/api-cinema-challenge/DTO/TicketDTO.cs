using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public TicketDTO(Ticket ticket) { 
        
            TicketId = ticket.TicketId;
            SeatNumber = ticket.SeatNumber;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
        public int TicketId { get; set; }
        public int SeatNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

