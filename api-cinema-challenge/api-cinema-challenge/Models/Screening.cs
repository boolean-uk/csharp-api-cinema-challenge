using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("movie_id")]
        [ForeignKey("movies")]
        public int MovieId { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at", TypeName = "timestamp")]
        public DateTime StartsAt { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; }

        public Movie Movie { get; set; }
    }
}
