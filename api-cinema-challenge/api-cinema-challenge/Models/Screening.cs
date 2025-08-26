using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity {  get; set; }

        [Column("startsat")]
        public DateTime StartsAt { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Movies")]
        public int MovieId {  get; set; }

        public Movie Movie { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
