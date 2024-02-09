using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO
    {
        public MovieDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            IMDBRating = movie.IMDBRating;
            RuntimeMin = movie.RuntimeMin;
            Description = movie.Description;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string IMDBRating { get; set; }
        public int RuntimeMin { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime UpdatedAt { get; set;}
    }
}
