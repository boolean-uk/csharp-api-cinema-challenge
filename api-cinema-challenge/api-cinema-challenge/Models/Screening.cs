using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening_table")]
    public class Screening
    {

        [ForeignKey("movie_id")]
        public int Id { get; set; }

        [Column("screem_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
    }
}
