using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [ForeignKey("movies")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Ticket> Ticket { get; set; }

    }
}
