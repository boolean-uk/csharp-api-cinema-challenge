using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Screening
    {

        public int Id { get; set; }


        public int screenNumber { get; set; }
        [ForeignKey("Movie")]
        public int movieId { get; set; }
        public Movie movie { get; set; }
        public int capacity { get; set; }

        //private DateTime _startsAt;
        public DateTime startsAt { get; set; }

        [JsonIgnore]

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


    }
}
