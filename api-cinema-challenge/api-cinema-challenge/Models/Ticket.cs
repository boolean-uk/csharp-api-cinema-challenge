namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int screeningId { get; set; }
        public Screening screening { get; set; }
        public int seatId { get; set; }
        public Seat seat { get; set; }

        public int? bookingId { get; set; }
        public Booking booking { get; set; }
        public float price { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}