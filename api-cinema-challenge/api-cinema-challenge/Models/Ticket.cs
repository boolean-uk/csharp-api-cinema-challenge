namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;

        public int ScreeningId { get; set; }
        public Screening Screening { get; set; } = default!;

        public string SeatLabel { get; set; } = default!;   // e.g. "B12"

        public DateTime CreatedAt { get; set; } // UTC
        public DateTime UpdatedAt { get; set; } // UTC
    }
}
