using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening : BaseEntity
    {

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("movie")]
        public virtual Movie Movie { get; set; }

        [Column("tickets")]
        public ICollection<Ticket> Tickets { get; set; }
    }
}
