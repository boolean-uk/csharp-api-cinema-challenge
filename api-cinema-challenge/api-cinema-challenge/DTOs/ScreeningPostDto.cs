namespace api_cinema_challenge.DTOs;

public class ScreeningPostDto
{
    public required int ScreenNumber { get; set; }
    public required int Capacity { get; set; }
    public required DateTime StartsAt { get; set; }
}