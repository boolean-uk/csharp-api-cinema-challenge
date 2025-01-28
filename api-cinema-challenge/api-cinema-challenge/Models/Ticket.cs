using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("num_seats")]
        public int NumSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(Customer))]
        [Column("customer_id")]
        public int Customer_id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey(nameof(Screening))]
        [Column("screening_id")]
        public int Screening_id { get; set; }
        public Screening Screening { get; set; }

    }
}
