namespace api_cinema_challenge.Models.DTOs.Ticket
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
