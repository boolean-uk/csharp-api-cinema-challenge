namespace api_cinema_challenge.DTOs;

public class MovieUpdateDto
{
    public string? Title { get; set; }
    public double? Rating { get; set; }
    public string? Description { get; set; }
    public int? RuntimeMins { get; set; }
}