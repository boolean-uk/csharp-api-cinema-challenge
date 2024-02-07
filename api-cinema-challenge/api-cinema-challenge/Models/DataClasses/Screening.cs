using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.NewFolder
{
    public class Screening
    {
        [Column("screening_id")]
        public int Id { get; set; }
        [Column("fk_movie_id")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        [Column("screening_capacity")]
        public int Capacity { get; set; }
        [Column("screening_starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("screening_created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("screening_updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
