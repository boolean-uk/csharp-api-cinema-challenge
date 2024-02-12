namespace api_cinema_challenge.Models.Interfaces
{
    public interface IScreening
    {
        int ScreenNumber { get; set; }
        int Capacity { get; set; }
        DateTime StartsAt { get; set; }
    }
}
