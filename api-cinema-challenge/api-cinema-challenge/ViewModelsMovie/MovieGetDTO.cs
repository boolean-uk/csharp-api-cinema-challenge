using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsMovie
{
    public class MovieGetDTO
    {
        public string status { get; set; }
        public List<MovieData> data { get; set; } = new List<MovieData>();

        public MovieGetDTO(List<Movie> movies)
        {
            this.status = "success";
            foreach (var movie in movies)
            {
                this.data.Add(new MovieData(movie));
            }
        }
    }
}
