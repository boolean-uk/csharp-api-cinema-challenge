using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class MoviePost
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public IEnumerable<ScreeningPost>? screenings { get; set; } = new List<ScreeningPost>();
    }
}
