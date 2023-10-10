namespace api_cinema_challenge.Models
{
    public class MoviePost
    {
        public required string title { get; set; }
        public required string rating { get; set; }
        public required string description { get; set; }
        public required int runtimeMins { get; set; }
    }
}
