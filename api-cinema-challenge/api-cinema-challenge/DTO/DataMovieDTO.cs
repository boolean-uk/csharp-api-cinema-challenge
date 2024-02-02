using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class DataMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public DataMovieDTO(Movie movie)
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
}
