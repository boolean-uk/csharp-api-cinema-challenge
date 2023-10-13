using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.TicketDTOs
{
    public class CreateTicketDto
    {
        [Required]
        [Range(1, 20)] // maximum of 20 seats can be booked at once.
        public int NumSeats { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int ScreeningId { get; set; }
    }
}
