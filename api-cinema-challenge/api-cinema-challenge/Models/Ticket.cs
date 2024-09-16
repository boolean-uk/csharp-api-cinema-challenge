using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("customerid")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("screeningId")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("numseats")]
        public int NumSeats { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }
    }
}
