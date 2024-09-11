namespace api_cinema_challenge.ViewModels
{
    public class ScreeningPostModel
    {
        public int MovieId { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
