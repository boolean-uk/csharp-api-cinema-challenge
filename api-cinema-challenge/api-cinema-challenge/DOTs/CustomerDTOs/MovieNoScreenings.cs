using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.CustomerDTOs
{
    public class MovieNoScreenings
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int RunTimeMins { get; set; }

        public MovieNoScreenings(Movie movie)
        {
            Title = movie.Title;
            Description = movie.Description;
            Rating = movie.Rating;
            RunTimeMins = movie.RunTimeMins;
        }
    }
}
