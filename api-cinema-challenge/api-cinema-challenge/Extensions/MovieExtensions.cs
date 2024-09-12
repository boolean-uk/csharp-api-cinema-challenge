using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Extensions
{
    public static class MovieExtensions
    {
        public static MovieDTO ToMovieDTO(this Movie movie) 
        {
            List<ScreeningDTO> screeningsDTO = (from screening in movie.Screenings select screening.ToScreeningDTO()).ToList();
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
            };
        }

        public static Movie ToMovie(this MoviePostModel moviePost) 
        {
            return new Movie
            {
                Title = moviePost.Title,
                Rating = moviePost.Rating,
                Description = moviePost.Description,
                RuntimeMins = moviePost.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

        }
    }
}
