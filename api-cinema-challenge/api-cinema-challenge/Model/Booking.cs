using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    public class Booking
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Customer"), Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [ForeignKey("Screening"), Column("screening_id")]
        public int ScreeningId { get; set; }

        public virtual Screening Screening { get; set; }

        [Column("number_of_seats")]
        public int NumberOfSeats { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
    }
}
