using System.ComponentModel.DataAnnotations;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModels
{
    public class CreateMovie
    {
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [StringLength(10, ErrorMessage = "Rating cannot exceed 10 characters.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Runtime is required.")]
        [Range(1, 300, ErrorMessage = "Runtime must be between 1 and 300 minutes.")]
        public int RuntimeMins { get; set; }

        public IEnumerable<CreateScreening> Screenings { get; set; } = new List<CreateScreening>();
    }
}
