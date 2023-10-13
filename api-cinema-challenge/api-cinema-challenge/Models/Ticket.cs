namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public Customer Customer { get; set; }
        public Screening Screening { get; set; }
    }
}
