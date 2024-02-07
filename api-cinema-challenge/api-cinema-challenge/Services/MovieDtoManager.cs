using api_cinema_challenge.Models.MovieModels;

namespace api_cinema_challenge.Services
{
    public static class MovieDtoManager
    {
        public static OutputMovie Convert(Movie movie)
        {
            return new OutputMovie
            {
                Id = movie.Id,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                Title = movie.Title,
                Description = movie.Description,
                Rating = movie.Rating,
                Runtime = movie.Runtime
            };
        }

        public static IEnumerable<OutputMovie> Convert(IEnumerable<Movie> movies)
        {
            return movies.Select(Convert);
        }

        public static Movie Convert(InputMovie inputMovie)
        {
            return new Movie
            {
                Title = inputMovie.Title,
                Description = inputMovie.Description,
                Runtime = inputMovie.Runtime,
                Rating = inputMovie.Rating,
                Screenings = ScreeningDtoManager.Convert(inputMovie.Screenings)
            };
        }

    }
}
