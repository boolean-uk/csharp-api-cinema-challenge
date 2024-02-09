using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOS
{
    public class CreateMovieDTO
    {
      
        public string Title { get; set; }
      
        public int Rating { get; set; }
       
        public string Description { get; set; }
      

        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
