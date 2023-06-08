using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Screen
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }
    }
}
