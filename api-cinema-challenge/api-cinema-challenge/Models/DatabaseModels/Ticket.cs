using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DatabaseModels
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("numSeats")]
        public int NumSeats { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set;}
        [ForeignKey("Customer")]
        [Column("customerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Screening")]
        [Column("screenId")]
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
    }
}
