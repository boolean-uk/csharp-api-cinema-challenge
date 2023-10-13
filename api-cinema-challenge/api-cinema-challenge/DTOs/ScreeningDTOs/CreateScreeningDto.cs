using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.ScreeningDTOs
{
    public class CreateScreeningDto
    {
        [Required]
        [Range(1, 20)] // for maximum of 20 screens.
        public int ScreenNumber { get; set; }

        [Required]
        [Range(1, 300)] // for a maximum capacity of 300 seats.
        public int Capacity { get; set; }

        [Required]
        public DateTime StartsAt { get; set; }
    }
}
