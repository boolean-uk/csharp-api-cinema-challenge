namespace api_cinema_challenge.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public int seatNumber { get; set; }
        public int rowNumber { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Ticket> Tickets { get; set; }

    }
}