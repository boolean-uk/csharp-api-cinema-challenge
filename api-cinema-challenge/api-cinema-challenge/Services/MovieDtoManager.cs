using api_cinema_challenge.Models.MovieModels;

namespace api_cinema_challenge.Services
{
    public static class MovieDtoManager
    {
        public static Movie Convert(InputMovie inputMovie)
        {
            return new Movie
            {
                Title = inputMovie.Title,
                Description = inputMovie.Description,
                Runtime = inputMovie.Runtime,
                Rating = inputMovie.Rating,
            };
        }
    }
}
