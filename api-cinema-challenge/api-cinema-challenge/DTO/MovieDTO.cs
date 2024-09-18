using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class PostMovieDTO
    {
        public string Title { get; set; }
        public Rating Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public PostScreeningDTO Screening { get; set; }


    }

    public class GetMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Rating Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
       

    }

    public class UpdateMovieDTO
    {
        public string Title { get; set; }
        public Rating Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
