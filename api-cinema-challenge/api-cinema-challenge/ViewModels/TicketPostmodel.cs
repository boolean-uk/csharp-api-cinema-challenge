using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class TicketPostmodel
    {
        [Required]
        public int NumSeats { get; set; }
    }
}
