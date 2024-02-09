using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOS
{
    public class CreateTicketDTO
    {

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int ScreeningId { get; set; }

        [Required]
        public int NumSeats { get; set; }
    }
}
