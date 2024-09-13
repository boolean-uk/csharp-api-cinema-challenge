using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }

        public int NumSeats { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public TicketDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
    }

}
