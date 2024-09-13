namespace api_cinema_challenge.Models
{
    public class Movie
    {

        public int Id { get; set; } 

        public string Title { get; set; }    

        public int Rating { get; set; }

        public string Description { get; set; }

        public int Runtime { get; set; }

        public ICollection<Screening> screenings { get; set; }
    }
}
