using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("startsAt")]
        public DateTime StartsAt { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("movieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Column("screenNumber")]
        public int ScreenNumber { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
