using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column("id")]
        public int id { get; set; }

        [Column("movie_id")]
        public int movieId { get; set; }    

        [Column("screen_number")]
        public int screenNumber { get; set; }

        [Column("capacity")]
        public int capacity { get; set; }

        [Column("starts_at")]
        public DateTime startsAt { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set;}

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}
