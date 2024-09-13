using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("numseats")]
        public int NumSeats { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAT { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAT { get; set; }

        [ForeignKey("screeningid")]
        public int ScreeningId { get; set; }

        [ForeignKey("customerid")]
        public int CustomerID { get; set; }

        public Screening Screening { get; set; }
        public Customer Customer { get; set; }
    }
}
