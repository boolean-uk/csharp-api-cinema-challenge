using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket : BaseEntity
    {
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("sceening_id")]
        public int ScreeningId { get; set; }

        [Column("screening")]
        public Screening Screening { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("customer")]
        public Customer Customer { get; set; }
    }
}
