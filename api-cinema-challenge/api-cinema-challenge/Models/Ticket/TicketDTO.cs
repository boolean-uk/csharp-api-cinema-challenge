using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Ticket
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int numSeats { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
