using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Factories
{
    public static class MovieFactory
    {
        public static MovieDto DtoFromMovie(Movie movie)
        {
            var dto = new MovieDto();

            dto.Id = movie.Id;
            dto.Title = movie.Title;
            dto.Rating = movie.Rating;
            dto.Description = movie.Description;
            dto.RuntimeMins = movie.RuntimeMins;
            dto.CreatedAt = movie.CreatedAt;
            dto.UpdatedAt = movie.UpdatedAt;

            return dto;
        }

        public static Movie MovieFromPostDto(MoviePostDto dto)
        {
            var movie = new Movie();

            movie.Title = dto.Title;
            movie.Rating = dto.Rating;
            movie.Description = dto.Description;
            movie.RuntimeMins = dto.RuntimeMins;

            return movie;
        }

        public static Movie MovieFromPutDto(MoviePutDto dto, Movie oldMovie)
        {  
            var updated = oldMovie;

            if (dto.Title is not null) updated.Title = dto.Title;
            if (dto.Rating is not null) updated.Rating = dto.Rating;
            if (dto.Description is not null) updated.Description = dto.Description;
            if (dto.RuntimeMins != 0) updated.RuntimeMins = dto.RuntimeMins;

            return updated;
        }
    }
}
