using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}