using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("numSeats")]
        public int NumSeats { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [Column("customerId")]
        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column("screeningId")]
        [ForeignKey("screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
