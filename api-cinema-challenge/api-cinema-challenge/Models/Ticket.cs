using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        [Column("customerid")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Screening")]
        [Column("screeningid")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        [Column("numseats")]
        public int NumSeats { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
