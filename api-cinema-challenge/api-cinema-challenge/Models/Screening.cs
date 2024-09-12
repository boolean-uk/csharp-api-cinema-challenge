using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("movieid")]
        public int MovieId { get; set; }
        [Column("screenid")]
        public int ScreenId { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("startsat")]
        public DateTime StartsAt { get; set; }
        [Column("createdat")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Movie Movie { get; set; }
    }
}
