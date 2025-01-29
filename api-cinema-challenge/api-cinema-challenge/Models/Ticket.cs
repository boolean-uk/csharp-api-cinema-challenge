using api_cinema_challenge.Enums;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public TicketType TicketType { get; set; } = TicketType.Adult;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        public int SeatId { get; set; }
        private int _screenId;
        public int ScreenId { get { return Screening?.ScreenId ?? _screenId; } set { _screenId = value; } }
        public Seat Seat { get; set; }
    }
}
