using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("screen_number")]
        [Required]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        [Required]
        public int Capacity { get; set; }

        [Column("starts_at")]
        [Required]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
