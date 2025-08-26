using api_cinema_challenge.DOTs.CustomerDTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.MovieDTOs
{
    public class MovieGet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int RunTimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<ScreeningsNoMovie> Screenings { get; set; } = new List<ScreeningsNoMovie>();

        public MovieGet(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Description = movie.Description;
            Rating = movie.Rating;
            RunTimeMins = movie.RunTimeMins;
            Screenings = movie.Screenings.Select(x => new ScreeningsNoMovie(x));
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }

    }
}
