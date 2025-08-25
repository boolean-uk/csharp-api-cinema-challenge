using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs;

public class MoviePostDto
{
    public required string Title { get; set; }
    public required double Rating { get; set; }
    public required string Description { get; set; }
    public required int RuntimeMins { get; set; }
    public required ICollection<MoviePostScreeningDto> Screenings { get; set; }
}