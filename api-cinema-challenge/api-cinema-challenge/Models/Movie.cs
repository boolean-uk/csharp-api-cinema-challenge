using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public List<Screening> Screenings { get; set; } = new();

        public Movie() { }
        public Movie(PostMovie movie)
        {
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = (int)movie.RuntimeMins;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Movie(PutMovie movie)
        {
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = (int)movie.RuntimeMins;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public MovieDto(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }
    }

    public class GetMovieDto : MovieDto
    {
        public List<ScreeningDto> Screenings { get; set; } = new();

        public GetMovieDto (Movie movie) : base(movie)
        {
            foreach (Screening screening in movie.Screenings)
            {
                Screenings.Add(new ScreeningDto(screening));
            }
        }
    }

    public class PostMovie
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int? RuntimeMins { get; set; }
    }

    public class PutMovie : PostMovie { }
}
