using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        //[Key]
        [Column ("id")]
        public int Id { get; set; }

        [Column ("screen_number")]
        public int ScreanNumber {  get; set; }

        [Column ("capacity")]
        public int Capacity { get; set; }

        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("start_time")]
        public DateTime StartsAt { get; set; } = DateTime.UtcNow;

        [Column("created_time")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_time")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;



        //public DateTime EndsAt { get; set;}
        public Movie? Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();



    }
}
