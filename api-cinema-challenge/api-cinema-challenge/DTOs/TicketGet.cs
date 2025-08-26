namespace api_cinema_challenge.DTOs
{
    public class TicketGet
    {
        public int Id { get; set; }
        
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
