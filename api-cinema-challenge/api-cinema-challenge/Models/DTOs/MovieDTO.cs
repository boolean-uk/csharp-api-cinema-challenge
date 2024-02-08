using api_cinema_challenge.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs;

public class MovieDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Rating { get; set; }
    public string Description { get; set; }
    public int RuntimeMins { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public static MovieDTO ToDTO(Movie movie)
    {
        return new MovieDTO()
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
}
