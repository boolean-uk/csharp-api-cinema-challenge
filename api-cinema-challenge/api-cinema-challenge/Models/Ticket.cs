using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket : AbstractModel
    {
        [Required]
        [Column("customer_id")]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Required]
        [Column("screening_id")]
        [ForeignKey(nameof(Screening))]
        public int ScreeningId { get; set; }

        [Required]
        [Column("seat_num")]
        public int SeatNumber { get; set; }
    }
}
