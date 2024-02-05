namespace api_cinema_challenge.Models
{
    public class Booking
    {

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Ticket> tickets { get; set; }

    }
}
