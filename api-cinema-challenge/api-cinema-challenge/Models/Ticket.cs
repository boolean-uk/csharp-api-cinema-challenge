using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    [PrimaryKey("Id")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("fk_screening_id")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        [Column("fk_customer_id")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Column("number_of_seats")]
        public int NumSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
