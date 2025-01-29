namespace api_cinema_challenge.Request
{
    public class ScreeningPost
    {
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
        public int Capacity { get; set; }
    }
}
