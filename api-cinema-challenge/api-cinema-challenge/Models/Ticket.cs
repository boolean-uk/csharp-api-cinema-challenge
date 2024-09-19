using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket : BaseClass
    {
        [Key]
        public int Id { get; set; }
        public int NumSeats { get; set; }

        [ForeignKey(nameof(Screening))]
        public int ScreeningId { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

    }
}
