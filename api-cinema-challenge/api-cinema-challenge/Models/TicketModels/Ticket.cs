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
        public required int NumSeats { get; set; }

        [Column("screening_id")]
        public required int ScreeningId { get; set; }
        //public required Screening Screening { get; set; }

        [Column("customer_id")]
        public required int CustomerId { get; set; }
        //public required Customer Customer { get; set; }
    }
}
