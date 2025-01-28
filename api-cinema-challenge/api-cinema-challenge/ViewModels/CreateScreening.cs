using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class CreateScreening
    {
        [Required(ErrorMessage = "Screen number is required.")]
        [Range(1, 20, ErrorMessage = "Screen number must be between 1 and 20.")]
        public int ScreenNumber { get; set; }

        [Required(ErrorMessage = "Capacity is required.")]
        [Range(10, 500, ErrorMessage = "Capacity must be between 10 and 500.")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        public DateTime StartsAt { get; set; }

        [Required(ErrorMessage = "Movie ID is required.")]
        public int MovieId { get; set; }
    }
}
