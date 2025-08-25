using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("screening_id")]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("movie")]
        public Movie Movie { get; set; }

        [Column("screening_screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("screening_capacity")]
        public int Capacity { get; set; }

        [Column("screening_startsAt")]
        public DateTime StartsAt { get; set; }

        [Column("screening_createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("screening_updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("tickets")]
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
