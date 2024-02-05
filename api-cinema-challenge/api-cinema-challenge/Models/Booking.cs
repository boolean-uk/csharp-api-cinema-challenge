using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("id")]
        public int bookingId { get; set; }

        [Column("user_id")]
        public int userId { get; set; }
        public User User { get; set; }

        [Column("screening_id")]
        public int screeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("booing_time")]
        public DateTime BookingTime { get; set; }

        public List<Ticket> Tickets {  get; set; } 
    }
}
