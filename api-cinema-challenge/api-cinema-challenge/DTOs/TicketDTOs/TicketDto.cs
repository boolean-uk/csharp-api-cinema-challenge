namespace api_cinema_challenge.DTOs.TicketDTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
  
    }
}
