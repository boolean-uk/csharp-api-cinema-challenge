using api_cinema_challenge.Models.MovieModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.ScreeningModels
{
    [Table("screening")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("statsAt")]
        public DateTime StartsAt { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
