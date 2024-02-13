namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }


        public Ticket() { }
        public Ticket(PostTicket ticket)
        {
            NumSeats = ticket.NumSeats;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public class TicketDto
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public TicketDto(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
    }

    public class PostTicket
    {
        public int NumSeats { get; set; }
    }
}
