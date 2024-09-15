using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("movie")]
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
