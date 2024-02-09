using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public ICollection<ScreeningDTO> Screenings { get; set; } = new List<ScreeningDTO>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
