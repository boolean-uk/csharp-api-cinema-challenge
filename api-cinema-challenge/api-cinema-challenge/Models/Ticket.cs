using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("num_seats")]
        public int NumSeats { get; set; }

        [Column("screening_id")]
        public int ScreeningId { get; set; }

        public Screening Screening { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
