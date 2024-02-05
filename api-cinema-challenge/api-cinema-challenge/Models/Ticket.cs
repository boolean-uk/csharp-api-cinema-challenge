using api_cinema_challenge.Models.DTOs;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        [Column("number_of_seats")]
        public int NumberOfSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public TicketDTO ToDTO()
        {
            return new TicketDTO
            {
                Id = Id,
                NumberOfSeats = NumberOfSeats,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };
        }
    }
}
