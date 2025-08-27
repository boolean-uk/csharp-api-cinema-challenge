namespace api_cinema_challenge.DTOs.Screenings
{
    public class ScreeningPostPut
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
