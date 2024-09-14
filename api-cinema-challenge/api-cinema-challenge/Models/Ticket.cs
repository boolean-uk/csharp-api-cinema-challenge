using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("NumberOfSeats")]
        public int NumberOfSeats { get; set; }

        [Column("CreatedAt")]
        public DateTime createdAt { get; set; }

        [Column("UpdateAt")]
        public DateTime updatedAt { get; set; }

        [ForeignKey("Customer")]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }

        [ForeignKey("Screening")]
        [Column("ScreeningId")]
        public int ScreeningId { get; set; }
        public Screening screening { get; set; }
        



    }
}
