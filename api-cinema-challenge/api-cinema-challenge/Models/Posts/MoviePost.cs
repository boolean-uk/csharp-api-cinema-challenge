using api_cinema_challenge.Models.Interfaces;

namespace api_cinema_challenge.Models.Posts
{
    public class MoviePost : IMovie
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public ICollection<ScreeningPost> Screenings { get; set; }
    }
}
