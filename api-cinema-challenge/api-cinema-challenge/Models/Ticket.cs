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

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Column("numSeats")]
        public int NumSeats { get; set; }

        [ForeignKey("customerFk")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("screeningFk")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
