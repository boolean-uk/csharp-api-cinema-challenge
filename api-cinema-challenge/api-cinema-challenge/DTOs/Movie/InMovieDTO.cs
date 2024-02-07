using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api_cinema_challenge.DTOs.Screening;

namespace api_cinema_challenge.DTOs.Movie
{
    public class InMovieDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public int Runtime { get; set; }
        [Required]
        public string Description { get; set; } 

        public List<InScreeningDTO> Screenings { get; set; } 

       

    }
}
