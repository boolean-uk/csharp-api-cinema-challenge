namespace api_cinema_challenge.DTO
{
    public class PostTicketDTO
    {
        public int numTicket { get; set;}
    }
    public class GetTicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
