namespace api_cinema_challenge.Models.Payload
{
    public class MoviePayload
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<ScreeningPayload> Screenings { get; set; }
    }
}
