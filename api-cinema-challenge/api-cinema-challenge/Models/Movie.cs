using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string tittle { get; set; }
        public string rating { get; set; }

        public string description { get; set; }
        public int runtime { get; set; }

        [JsonIgnore]

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
