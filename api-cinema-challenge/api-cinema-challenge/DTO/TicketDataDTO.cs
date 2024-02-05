using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDataDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }

        public TicketDataDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
        }
    }
}
