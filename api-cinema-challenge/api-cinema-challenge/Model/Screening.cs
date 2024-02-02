using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    [Table("screening")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("screennumber")]
        public int ScreenNumber { get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("startsat")]
        public DateTime StartsAt { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("movie")]
        [Column("movieid")]
        public int MovieId { get; set; } // FK

        public Movie? Movie { get; set; } // Navigation property
    }
}
