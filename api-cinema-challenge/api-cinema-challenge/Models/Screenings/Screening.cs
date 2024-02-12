using api_cinema_challenge.Models.Movies;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Screenings
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("movie_id")]
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ScreeningDto ToDto()
        {
            return new ScreeningDto
            {
                Id = Id,
                StartsAt = StartsAt,
                ScreenNumber = ScreenNumber,
                Capacity = Capacity,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };
        }
    }
}
