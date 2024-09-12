using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModelsTicket
{
    public class InputTicketDTO
    {
        [Required]
        public int numSeats { get; set; }
    }
}
