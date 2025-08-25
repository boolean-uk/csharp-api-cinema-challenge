using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        [Column("TicketId")]
        public int Id { get; set; }

        [Required]
        [Column("NumsSeats")]
        public int NumSeats { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
       
        // Foreign key to Screening
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; } = null!;
        
        // Foreign key to Customer
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;


    }
}
