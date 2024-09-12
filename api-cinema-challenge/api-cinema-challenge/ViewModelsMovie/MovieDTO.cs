using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsMovie
{
    public class MovieDTO
    {
        public string status { get; set; }
        public MovieData data { get; set; }

        public MovieDTO(Movie movie)
        {
            this.status = "success";
            this.data = new MovieData(movie);
        }
    }
}
