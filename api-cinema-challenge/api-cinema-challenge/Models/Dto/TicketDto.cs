using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
