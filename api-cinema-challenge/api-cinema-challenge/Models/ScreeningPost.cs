namespace api_cinema_challenge.Models
{
    public class ScreeningPost
    {
        public required int screenNumber { get; set; }
        public required int capacity { get; set; }
        public required DateTime startsAt { get; set; }
    }
}
