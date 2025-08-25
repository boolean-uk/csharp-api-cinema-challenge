using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs.Tickets
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int numSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
