using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class TicketPostmodel
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int ScreeningId { get; set; }
        [Required]
        public int NumSeats { get; set; }
    }
}
