using api_cinema_challenge.Models.NewFolder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DataClasses
{
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }
        [Column("fk_customer_id")]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        [Column("fk_screening_id")]
        [ForeignKey(nameof(Screening))]
        public int ScreeningId { get; set; }
        public int NumSeats { get; set; }
        [Column("ticket_created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("ticket_updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
