using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

       /* //FK props to Customer
        [Column ("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       */

        //FK props to Movie
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
