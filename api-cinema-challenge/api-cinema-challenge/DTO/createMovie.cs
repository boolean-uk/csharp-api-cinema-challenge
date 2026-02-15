using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class createMovie
    {        
        public string Title { get; set; }       
        public string Rating { get; set; }       
        public string Description { get; set; }        
        public int RuntimeMins { get; set; }
    }
}
