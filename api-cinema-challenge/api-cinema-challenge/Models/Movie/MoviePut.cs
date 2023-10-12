using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Movie
{
    [NotMapped]
    public class MoviePut
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}