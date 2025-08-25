using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int RuntimeMins { get; set; }
    }
}
