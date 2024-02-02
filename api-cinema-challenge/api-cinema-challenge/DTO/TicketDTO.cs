using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    
    public class TicketDTO
    {
      
        public int TicketId { get; set; }
       
        public int NumSeats { get; set; }
       
        public DateTime CreatedAt { get; set; }
       
        public DateTime UpdatedAt { get; set;}

        // internal
        public UserAllDetailsDTO User { get; set; }
        public ScreeningAllDetailsDTO Screening { get; set; }

        public TicketDTO(Ticket ticket) {
            TicketId = ticket.TicketId;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
            User = new UserAllDetailsDTO(ticket.User);
            Screening = new ScreeningAllDetailsDTO(ticket.Screening);
        }
       
    }
}
