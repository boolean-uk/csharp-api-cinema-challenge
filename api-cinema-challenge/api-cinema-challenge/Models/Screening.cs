using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        
        [Column("movieid")]
        [ForeignKey("Movie")]
        [JsonIgnore]
        public int MovieId { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("start")]
        public DateTime StartsAt { get; set; }

        [Column("created")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated")]
        public DateTime UpdatedAt { get; set; }
    }
}
