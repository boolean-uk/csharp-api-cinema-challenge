using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int RuntimeMins { get; set; }
        public IEnumerable<Screening>? Screenings { get; set; } = new List<Screening>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
