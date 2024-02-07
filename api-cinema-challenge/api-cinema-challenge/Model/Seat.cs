using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    public class Seat
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }

        [Column("row_number")]
        public int RowNumber { get; set; }

        [ForeignKey("Screen"), Column("screen_id")]
        public int ScreenId { get; set; }

        public virtual Screen Screen { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
