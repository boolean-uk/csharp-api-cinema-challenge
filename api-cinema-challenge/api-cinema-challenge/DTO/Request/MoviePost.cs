using api_cinema_challenge.DTO.Response;

namespace api_cinema_challenge.DTO.Request
{
    public class MoviePost
    {
        public string title { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public string rating { get; set; }
        public List<MinimalScreeningPost>? screening { get; set; }
    }
    public class MinimalScreeningPost
    {
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
    }
}
