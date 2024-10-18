namespace api_cinema_challenge.Models
{
    public class Screening
    {    
        public int Id { get; set; }

        public int capacity { get; set; }

        public DateTime startsAT { get; set; }

        public int MovieId { get; set; }

        public Movie movie { get; set; }

        public ICollection<Ticket> tickets { get; set; }

        public ICollection<Customer> customers { get; set; }

    }
}
