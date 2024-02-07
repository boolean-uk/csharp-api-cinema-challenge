using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.ScreeningModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.TicketModels
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("numSeats")]
        public int NumSeats { get; set; }

        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
