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
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAT { get; set; }

        [Column("movie_id")]
        //[ForeignKey("Movie")]
        public int MovieID { get; set; }
        //public Movie Movie { get; set; }
    }
}
