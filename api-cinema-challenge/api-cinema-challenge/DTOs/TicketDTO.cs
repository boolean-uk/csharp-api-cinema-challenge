namespace api_cinema_challenge.DTOs
{
    public class TicketDTO
    {
        public int TicketId { get; set; }
        public string MovieTitle { get; set; }
        public int NumberOfSeats {  get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
