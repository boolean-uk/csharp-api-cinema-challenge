namespace api_cinema_challenge.Models.TicketModels
{
    public class OutputTicket
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public int NumSeats { get; set; }
    }
}
