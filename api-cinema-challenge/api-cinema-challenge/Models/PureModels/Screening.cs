using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("screening_id")]
        public int ScreeningId { get; set; }

        [Column("screen_numbers")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("startsAt")]
        public DateTime Starts { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set;}

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set;}

        [Column("movie_id")]
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
