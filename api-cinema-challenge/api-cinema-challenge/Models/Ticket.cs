using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required]
        [Column("SeatNumber")]
        public int NumSeats { get; set; }
        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        public Customer customer { get; set; }
        public Screening screening { get; set; }
    }
}
