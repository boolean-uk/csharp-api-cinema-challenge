using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Screening
{
    public class Screening
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
    }
}