using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening : ParentModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("movies")]
        public int MovieId { get; set; }

        [Column("screennumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("startsat")]
        public DateTime startsAt { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
