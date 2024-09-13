using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("screennumber")]
        public int ScreenNumber { get; set; }
        [Column("startsAt")]
        public DateTime StartsAt { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAT { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAT { get; set; }

        [ForeignKey("movieid")]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
