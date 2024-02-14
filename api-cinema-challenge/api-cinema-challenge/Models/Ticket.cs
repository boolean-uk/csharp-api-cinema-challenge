namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties for the related Customer and Screening
        public Customer Customer { get; set; }
        public Screening Screening { get; set; }
    }
}
