using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("numSeats")]
        public int NumberOfSeats { get; set; }
        [Column("screeningId")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        [Column("customerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
