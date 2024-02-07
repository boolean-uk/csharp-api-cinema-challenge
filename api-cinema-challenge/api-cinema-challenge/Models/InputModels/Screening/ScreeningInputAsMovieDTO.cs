using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.InputModels.Screening
{
    public class ScreeningInputAsMovieDTO(int ScreenNumber, int Capacity, string StartsAt)
    {
        [Required]
        public int ScreenNumber { get; set; } = ScreenNumber;

        [Required]
        public int Capacity { get; set; } = Capacity;

        [Required]
        public string StartsAt { get; set; } = StartsAt;

    }
}
