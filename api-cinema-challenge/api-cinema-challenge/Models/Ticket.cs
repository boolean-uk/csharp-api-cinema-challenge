using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("ticket_id")]
        public int Id { get; set; }

        [Column("fk_screening_id")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("fk_seat_id")]
        [ForeignKey("Seat")]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
