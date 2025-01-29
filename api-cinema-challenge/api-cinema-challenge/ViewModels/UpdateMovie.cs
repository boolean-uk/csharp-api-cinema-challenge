using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class UpdateMovie
    {
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [StringLength(10, ErrorMessage = "Rating cannot exceed 10 characters.")]
        public string Rating { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Range(1, 300, ErrorMessage = "Runtime must be between 1 and 300 minutes.")]
        public int RuntimeMins { get; set; }
    }
}
