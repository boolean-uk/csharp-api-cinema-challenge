using api_cinema_challenge.DTOs.Screenings;

namespace api_cinema_challenge.DTOs.Movies
{
    public class MoviePost
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<ScreeningPost>? screenings { get; set; }
    }
}
