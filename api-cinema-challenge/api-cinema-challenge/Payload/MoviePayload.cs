using api_cinema_challenge.Models;

namespace api_cinema_challenge.Payload
{
    public class MoviePayload
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int runtimeMins { get; set; }
        public List<ScreeningPayload> Screenings { get; set; }


    }
}
