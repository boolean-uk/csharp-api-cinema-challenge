namespace api_cinema_challenge.DTOs.Screening
{
    public class ScreeningPostModel
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public string StartsAt { get; set; } = "YYYY-MM-DD HH:MM:SS";
    }
}
