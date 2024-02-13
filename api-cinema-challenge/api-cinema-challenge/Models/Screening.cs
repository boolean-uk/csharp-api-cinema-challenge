using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("screening_id")]
        public int Id { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("fk_movie_id")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("fk_hall_id")]
        [ForeignKey("Hall")]
        public int HallId { get; set; }
        public Hall Hall { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
