using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO : BaseDTO
    {
        public TicketDTO(Ticket ticket) { 
            Id = ticket.Id;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;

            NumSeats = ticket.NumSeats;
        }
        public int NumSeats { get; set; }
    }
}
