namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<Screening> screenings { get; set; } = new List<Screening>();

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
