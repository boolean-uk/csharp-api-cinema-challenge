using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.DTOs
{
    public class GetMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PostMovieDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public ICollection<PostScreeningDTO> Screenings { get; set; }
    }

    public class PatchMovieDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int? RuntimeMins { get; set; }
    }
}
