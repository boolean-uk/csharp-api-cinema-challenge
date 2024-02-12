using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
