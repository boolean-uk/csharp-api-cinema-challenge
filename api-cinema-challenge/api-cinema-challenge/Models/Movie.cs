namespace api_cinema_challenge.Models
{
    public class Movie
    {



        public int Id { get; set; } 
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public DateTime Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Screening> Screenings { get; set; }


    }
}
