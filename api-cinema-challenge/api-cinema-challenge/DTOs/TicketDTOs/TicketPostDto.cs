using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.TicketDTOs
{
    public class TicketPostDto
    {
        [Required]
        public int NumSeats { get; set; }
    }
}
