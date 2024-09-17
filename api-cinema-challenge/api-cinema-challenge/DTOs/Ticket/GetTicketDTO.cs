namespace api_cinema_challenge.DTOs.Ticket
{
    public class GetTicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ScreeningId { get; set; }
        public int ScreeningNumber { get; set; }
        public DateTime StartAt { get; set; }
        public string MovieTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
