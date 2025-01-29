namespace api_cinema_challenge.DTO
{
    public record TicketPost(int SeatId, string TicketType);
    public class TicketView
    {
        // Properties
        public int Id { get; set; }
        public string TicketType { get; set; }
        public double Price { get; set; }
        public ScreenName Screen { get; set; }
        public SeatInternal Seat { get; set; }
        public MovieSimple Movie { get; set; }
        public ScreeningSimple Screening { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
