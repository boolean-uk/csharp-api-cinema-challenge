using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class TicketPost
    {
        [Required]
        public required int numSeats { get; set; }
    }
}
