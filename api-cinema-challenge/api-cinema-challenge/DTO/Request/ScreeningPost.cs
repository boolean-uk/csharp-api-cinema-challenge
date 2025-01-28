namespace api_cinema_challenge.DTO.Request
{
    public class ScreeningPost
    {
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
    }
}
