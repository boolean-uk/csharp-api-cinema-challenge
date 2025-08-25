namespace api_cinema_challenge.DTOs.Screening
{
    public class ScreeningPostDto
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
