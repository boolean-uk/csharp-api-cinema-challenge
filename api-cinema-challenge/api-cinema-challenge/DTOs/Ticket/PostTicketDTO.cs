namespace api_cinema_challenge.DTOs.Ticket
{
    public class PostTicketDTO
    {
        public int NumSeats { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
    }
}
