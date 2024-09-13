using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("seat_number")]
        public int NumSeats { get; set; }

        [ForeignKey("customer_id")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        
        [ForeignKey("screening_id")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }
      
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
      
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}


