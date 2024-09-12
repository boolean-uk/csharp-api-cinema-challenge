using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Column("Id")]
        public int Id { get; set; }
        [ForeignKey("Customer_Id")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Screening_Id")]
        public int ScreeningID { get; set; }
        public Screening Screening { get; set; }
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
