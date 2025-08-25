using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs
{
    public class TicketDTO
    {
        public int NumSeats { get; set; }
        public ScreeningDTO Screening { get; set; }
        public CustomerDTO Customer { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
