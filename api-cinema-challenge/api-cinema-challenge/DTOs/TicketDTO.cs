namespace api_cinema_challenge.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public CustomerDTO Customer { get; set; }
        public ScreeningDTO Screening { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class MinimalTicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
