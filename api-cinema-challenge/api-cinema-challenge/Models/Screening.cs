using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        public int movieId { get; set; }

        [Column("screenNumber")]
        public int screenNumber { get; set; }

        [Column("capacity")]
        public int capacity { get; set; }

        [Column("startsAt")]
        public DateTime startsAt { get; set; }

        [Column("createdAt")]
        public DateTime createdAt { get; set; }

        [Column("updatedAt")]
        public DateTime updatedAt { get; set; }
    }
}
