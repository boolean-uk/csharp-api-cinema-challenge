using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket : ParentModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("numseats")]
        public int NumSeats { get; set; }

        [ForeignKey("screenings")]
        public int ScreeningId { get; set; }

        [ForeignKey("customers")]
        public int CustomerId { get; set; }

        public Screening Screening { get; set; }
        public Customer Customer { get; set; }

    }
}
