namespace api_cinema_challenge.DTOs
{
    public class ResponseTicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ScreeningId { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime ScreeningStartsAt { get; set; }
        public string MovieName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class ResponseTicketDTOCustomerLess
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public int ScreeningId { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime ScreeningStartsAt { get; set; }
        public string MovieTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PostTicketDTO
    {
        public int NumSeats { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
    }
}
