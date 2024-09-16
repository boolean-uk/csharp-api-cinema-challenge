using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("movieid")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("screennumber")]
        public int ScreenNumber { get; set; }

        [Column("startsat")]
        public DateTime StartsAt { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}

