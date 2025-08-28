using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int NumSeats { get; set; }
        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        [ForeignKey("screening")]
        public int ScreeningId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
