using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public string RuntimeMins { get; set; }

        public MovieDTO(Movie movie) {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
        }

        public static List<MovieDTO> FromRepository(IEnumerable<Movie> movies) {
            List<MovieDTO> ret = new List<MovieDTO>();
            foreach (Movie movie in movies)
            {
                ret.Add(new MovieDTO(movie));
            }
            return ret;
        }
    }
}