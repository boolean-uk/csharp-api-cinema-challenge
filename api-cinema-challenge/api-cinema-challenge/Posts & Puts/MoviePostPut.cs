using api_cinema_challenge.Models;

namespace api_cinema_challenge.Posts___Puts
{
    public class MoviePostPut
    {
        public string Title { get; set; }

        public string Rating { get; set; }
        public string Description { get; set; }

        public int RuntimeMins { get; set; }

    }
}
