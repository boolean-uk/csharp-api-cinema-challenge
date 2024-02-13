using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.DTO_Ticket
{
    public class TicketDTO
    {
        public int id { get; set; }
        public int numbSeats { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public TicketDTO(Ticket ticket)
        {
            id = ticket.id;
            numbSeats = ticket.numbSeats;
            createdAt = ticket.createdAt;
            updatedAt = ticket.updatedAt;
        }
    }
}
