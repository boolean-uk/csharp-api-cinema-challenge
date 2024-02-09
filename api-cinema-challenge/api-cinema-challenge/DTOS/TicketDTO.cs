using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOS
{
    public class TicketDTO
    {
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
