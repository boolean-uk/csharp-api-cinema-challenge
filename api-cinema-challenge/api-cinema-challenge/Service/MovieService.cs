using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Service
{
    public static class MovieService
    {
        public static Movie toMovie(MovieDto movieDto)
        {
            return new Movie()
            {
                Title = movieDto.Title,
                Rating = movieDto.Rating,
                Description = movieDto.Description,
                RuntimeMins = movieDto.RuntimeMins, 
                UpdatedAt = DateTime.UtcNow, 
                CreatedAt = DateTime.UtcNow
            };
        }

        public static Movie updateMovie(Movie movie, MovieDto movieDto)
        {
            movie.Title = movieDto.Title.Trim().Count() == 0 ? movie.Title : movieDto.Title;
            movie.Rating = movieDto.Rating.Trim().Count() == 0 ? movie.Rating : movieDto.Rating;
            movie.Description = movieDto.Description.Trim().Count() == 0 ? movie.Description : movieDto.Description;
            movie.RuntimeMins = movieDto.RuntimeMins <= 0 ? movie.RuntimeMins : movieDto.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            return movie;
        }
    }
}
