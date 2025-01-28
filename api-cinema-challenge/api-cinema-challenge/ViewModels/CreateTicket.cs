using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class CreateTicket
    {
        [Required(ErrorMessage = "Number of seats is required.")]
        [Range(1, 10, ErrorMessage = "Number of seats must be between 1 and 10.")]
        public int NumSeats { get; set; }
    }
}
