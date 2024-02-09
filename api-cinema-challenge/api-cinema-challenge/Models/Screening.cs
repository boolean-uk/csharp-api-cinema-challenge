using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public int Number { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("fk_movie_id")]
        [ForeignKey("movies")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }

    public class ScreeningPost
    {
        public int Number { get; set; }
        public int Capacity { get; set; }   
        public DateTime StartsAt { get; set; }
    }
}
