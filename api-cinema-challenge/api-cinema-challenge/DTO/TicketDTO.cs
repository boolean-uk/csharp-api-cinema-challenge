using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public CustomerDTO Customer { get; set; }
        public int ScreeningId { get; set; }
        public ScreeningDTO Screening { get; set; }
        public int numSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
