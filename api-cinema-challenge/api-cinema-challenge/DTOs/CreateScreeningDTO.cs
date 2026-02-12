using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs
{
    public class CreateScreeningDTO
    {
    
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int ScreenNumber { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public DateTime StartsAt { get; set; }

    }
}
