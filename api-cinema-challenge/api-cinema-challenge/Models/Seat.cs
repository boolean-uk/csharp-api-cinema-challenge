using api_cinema_challenge.Enum;

namespace api_cinema_challenge.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public SeatType SeatType { get; set; }

        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public List<Ticket> Tickets { get; set; } = [];
    }
}
