using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    [PrimaryKey("Id")]
    public class Ticket
    {
        [Column("ticket_id")]
        public int Id { get; set; }
        [Column("ticket_num_seats")]
        public int NumSeats { get; set; }
        [Column("screening_created_date")]
        public DateTime CreatedAt { get; set; }
        [Column("screening_updated_date")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        [ForeignKey("Screening")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
