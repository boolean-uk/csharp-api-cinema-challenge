using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("number_of_seats")]
        public int NumberOfSeats { get; set; }
        [Column("customer_id")]
        [ForeignKey("customers")]
        public int CustomerId { get; set; }
        [Column("screening_id")]
        [ForeignKey("screenings")]
        public int ScreeningId { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        // ! means that ticket is requiered to have customer and screening
        public Customer Customer { get; set; } = null!;
        public Screening Screening { get; set; } = null!;
    }
}
