using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Num seats is required")]

        public int NumSeats { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [Required(ErrorMessage = "Screening id is required")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
