using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class ScreeningPostModel
    {
        [Required]
        public int ScreenNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string StartsAt { get; set; }
    }
}
