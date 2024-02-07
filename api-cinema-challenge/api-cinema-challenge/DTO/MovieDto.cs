using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;

        public MovieDto(Movie movie) 
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            Runtime = movie.Runtime;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }

        
    }
}
