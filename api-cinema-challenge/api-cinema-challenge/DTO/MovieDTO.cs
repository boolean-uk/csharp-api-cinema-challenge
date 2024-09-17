using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class PostMovieDTO
    {
        public string Title { get; set; }
        public Rating Rating { get; set; }
        public string Dectription { get; set; }
        public int RuntimeMins { get; set; }
        
        public PostScreeningDTO Screening { get; set; }


    }

    public class GetMovieDTO
    {
       
    }
}
