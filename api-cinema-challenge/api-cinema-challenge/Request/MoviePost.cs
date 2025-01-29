using api_cinema_challenge.Models;

namespace api_cinema_challenge.Request
{
    public class MoviePost
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int? RuntimeMinutes { get; set; }
        public List<ScreeningPost>? screenings { get; set; } = new List<ScreeningPost>();

    }
}
