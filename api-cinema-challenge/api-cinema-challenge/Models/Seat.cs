using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("seats")]
    public class Seat
    {
        [Column("seat_id")]
        public int Id { get; set; }

        [Column("seat_row")]
        public string SeatRow { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }

        [Column("fk_hall_id")]
        [ForeignKey("Hall")]
        public int HallId { get; set; }
        public Hall Hall { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
