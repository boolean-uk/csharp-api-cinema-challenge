using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int ScreeningId { get; set; }
        [Column("screen_numbers")]
        public int ScreenNumber { get; set; }
        [Column("capacities")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }


        [Column("movie_id")]
        public int movieId { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
