using api_cinema_challenge.Models;
using System.Reflection;

namespace api_cinema_challenge.DTOs
{
    public static class MovieFactory
    {
        public static Movie NewMovie(MoviePost item)
        {
            if (item is null) return null;

            return new Movie()
            {
                Title = item.Title,
                Rating = item.Rating,
                Description = item.Description,
                RuntimeMins = item.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
        }
        public static MovieGet NewMovieGet(Movie item)
        {
            if (item is null) return null;

            return new MovieGet()
            {
                Id = item.Id,
                Title = item.Title,
                Rating = item.Rating,
                Description = item.Description,
                RuntimeMins = item.RuntimeMins,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt,
            };  
        }
    }
}
