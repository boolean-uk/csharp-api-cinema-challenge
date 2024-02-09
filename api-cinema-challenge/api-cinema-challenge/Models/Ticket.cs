using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column ("num_seats")]
        public int NumSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("screening_id")]
        public int ScreeningId { get; set; }
        public Screening screening { get; set; }

        [ForeignKey("customer_id")]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }

    }
}
