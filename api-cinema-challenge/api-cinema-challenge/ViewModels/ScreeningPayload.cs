namespace api_cinema_challenge.ViewModels;

public class ScreeningPayload
{
    public int MovieId { get; set; }
    public int ScreenNumber { get; set; }
    public int Capacity { get; set; }
    public DateTime startsAt { get; set; }
}