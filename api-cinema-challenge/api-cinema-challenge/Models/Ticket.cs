using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Ticket : BaseEntity
    {
        [Column("num_seats")]
        public int numSeats { get; set; }

        [Column("fk_screening_id")]
        public int screeningId { get; set; }

        [Column("screening")]
        public Screening Screening { get; set; }

        [Column("fk_customer_id")]
        public int customerId { get; set; }

        [Column("customer")]
        public Customer Customer { get; set; }

    }
}
