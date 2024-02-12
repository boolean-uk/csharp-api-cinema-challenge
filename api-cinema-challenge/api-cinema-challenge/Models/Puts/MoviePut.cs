using api_cinema_challenge.Models.Interfaces;
using api_cinema_challenge.Models.Posts;

namespace api_cinema_challenge.Models.Puts
{
    public class MoviePut : IMovie
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
    }
}
