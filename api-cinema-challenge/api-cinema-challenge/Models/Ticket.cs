using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("id")]
        public int Id {  get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; } = 1;
        [ForeignKey("Customer")]
        [Column("fk_customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Screening")]
        [Column("fk_screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        [Column("updated_at")]
        public DateTime UpdatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

        
    }
}
