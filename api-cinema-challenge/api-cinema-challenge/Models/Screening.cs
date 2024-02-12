using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]

    public class Screening
    {
        [Column("screen_id")]
        public int ScreeningId { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("screen_capacity")]
        public int ScreenCapacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        // Navigation property for the Movie related to this Screening
        

        [Column("fk_movie_id")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();  
    }
}
