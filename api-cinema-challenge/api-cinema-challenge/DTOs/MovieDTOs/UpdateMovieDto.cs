using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.ScreeningDTOs
{
    public class UpdateMovieDto
    {
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(10)]
        public string Rating { get; set; }

        [MaxLength(240)]
        public string Description { get; set; }

        [Range(1, 240)]
        public int RuntimeMins { get; set; }
    }
}
