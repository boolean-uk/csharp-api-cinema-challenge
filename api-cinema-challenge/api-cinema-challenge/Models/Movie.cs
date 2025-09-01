namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Rating { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; } // UTC
        public DateTime UpdatedAt { get; set; } // UTC

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
