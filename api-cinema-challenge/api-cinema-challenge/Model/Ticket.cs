using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    public class Ticket
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Seat"), Column("seat_id")]
        public int SeatId { get; set; }

        public virtual Seat Seat { get; set; }

        [ForeignKey("Screening"), Column("screening_id")]
        public int ScreeningId { get; set; }

        public virtual Screening Screening { get; set; }
    }
}
