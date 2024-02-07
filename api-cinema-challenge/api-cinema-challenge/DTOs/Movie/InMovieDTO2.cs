using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.Movie
{
    public class InMovieDTO2
    {
      
        public string Title { get; set; }
        
        public string Rating { get; set; }
     
        public int Runtime { get; set; }
        
        public string Description { get; set; }
    }
}
