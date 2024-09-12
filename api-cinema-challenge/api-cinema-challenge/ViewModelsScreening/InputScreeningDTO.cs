using System.ComponentModel.DataAnnotations;


namespace api_cinema_challenge.ViewModelsScreening
{
    public class InputScreeningDTO
    {
        [Required]
        public int ScreenNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        [RegularExpression(@"^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}$", ErrorMessage = "Invalid Format. Expected Format: YYYY-MM-DD HH:MM:SS")]
        public string StartsAt { get; set; }
    }
}
