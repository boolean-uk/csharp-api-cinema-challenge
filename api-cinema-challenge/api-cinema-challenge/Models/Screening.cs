using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; internal set; }
        [Column("screenNumber")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("startsAt")]
        public DateTime startsAt { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; internal set; }
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; internal set; }

        [Column("movieId")]
        [ForeignKey(nameof(Movie.Id))]
        public int MovieId { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
