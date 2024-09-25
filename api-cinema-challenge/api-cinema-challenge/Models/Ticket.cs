using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("number_of_seats")]
        public int numOfSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("customer_id")]
        public int CustomerId { get; set; }
        [ForeignKey("screening_id")]
        public int ScreeningId { get; set; }


    }
}
