using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Ticket
{
    [NotMapped]
    public class TicketPost
    {
        [Required]
        public int NumSeats { get; set; }
    }
}
