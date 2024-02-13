namespace api_cinema_challenge.Models.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
    }
}
