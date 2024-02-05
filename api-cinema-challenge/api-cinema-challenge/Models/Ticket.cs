using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int TicketId { get; set; }
        [Column("num_seats")]
        public int SeatNumber { get; set; } // numSeat is the most ambiguous nameing I have ever read numSeat = number of seats 
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        // Foreign key for User (Customer)
        [Column("user_id")]
        public int userId { get; set; }
        public User User { get; set; }

        // Foreign key for Screening
        [Column("screening_id")]
        public int screeningId { get; set; }
        public Screening Screening { get; set; }

        
    }
}
