namespace api_cinema_challenge.Presentation.DTOs.Screenings
{
    public class GetScreeningDTO
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
