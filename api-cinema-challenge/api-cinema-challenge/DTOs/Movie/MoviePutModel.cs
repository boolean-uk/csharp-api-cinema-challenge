using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.Movie
{
    public class MoviePutModel
    {
        public string? Title { get; set; }
        
        public string? Rating { get; set; }
        
        public string? Description { get; set; }
        
        public int? RuntimeMins { get; set; }
    }
}
