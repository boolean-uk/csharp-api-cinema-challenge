using api_cinema_challenge.Enums;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }

        public List<Screening> Screenings { get; set; } = [];
    }
}
