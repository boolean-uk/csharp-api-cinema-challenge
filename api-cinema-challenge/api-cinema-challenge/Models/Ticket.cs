namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int numOfSeats { get; set; }

        public int CustomerId { get; set; }

        public Customer customer { get; set; }

        public int screeningId { get; set; }

        public Screening screening { get; set; }
    }
}
