using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.ScreeningDTOs
{
    public class CreateMovieDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10)]
        public string Rating { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(1, 240)]
        public int RuntimeMins { get; set; }

        public List<CreateScreeningDto> Screenings { get; set; }
    }
}
