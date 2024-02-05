using System;
using System.Collections.Generic;
using System.Linq;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningForMovieDTO
    {
        public int Id { get; set; }
        public string ScreenName { get; set; }
        public DateTime StartsAt { get; set; }
    }

    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<ScreeningForMovieDTO> Screenings { get; set; }


        public static MovieDTO FromMovie(Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Description = movie.Description,
                Rating = movie.Rating,
                ReleaseDate = movie.ReleaseDate,
                Screenings = movie.Screenings?.Select(s => new ScreeningForMovieDTO
                {
                    Id = s.Id,
                    ScreenName = s.Screen?.name,
                    StartsAt = s.StartsAt
                }).ToList() ?? new List<ScreeningForMovieDTO>()
            };
        }

        public static List<MovieDTO> FromListOfMovies(List<Movie> movies)
        {
            return movies.Select(FromMovie).ToList();
        }
    }
}
