namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
