using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening : AbstractModel
    {
        [ForeignKey(nameof(Movie))]
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Required]
        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("starts_at")]
        public DateTime StartTime { get; set; }
    }
}
