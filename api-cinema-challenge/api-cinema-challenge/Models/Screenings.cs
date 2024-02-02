using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{ 
    [Table("screenings")]
    public class Screenings
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAT { get; set; }

        [Column("movie_id")]
        public int MovieID { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
