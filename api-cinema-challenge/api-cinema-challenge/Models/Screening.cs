using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        [Column("ScreeningId")]
        public int Id { get; set; }

        [Required]
        [Column("ScreenNumber")]
        public int ScreenNumber { get; set; }

        [Required]
        [Column("Capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("StartsAt")]
        public DateTime StartsAt { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Foreign key to Movie
        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; } = null!;
    }
}
