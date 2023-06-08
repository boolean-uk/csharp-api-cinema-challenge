
using System.ComponentModel;

namespace api_cinema_challenge.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [DefaultValue("")]
        public string Title { get; set; }
        [DefaultValue("")]
        public string Rating { get; set; }
        [DefaultValue("")]
        public string Description { get; set; } 
     
        public int RuntimeMins { get; set; }


        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }

    }
}
