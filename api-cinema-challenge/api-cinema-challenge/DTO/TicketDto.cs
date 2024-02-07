using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class TicketDto
    {
        public int Id { get; set; }

        public int numSeat { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        public TicketDto(Ticket ticket ) 
        { 
            Id = ticket.Id;
            numSeat = ticket.numSeat;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
              
        }  
    }

    
}
