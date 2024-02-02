using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieResponseDTO
    {
        public string Status { get; set; }
        public DataMovieDTO Datas { get; set; }

        public MovieResponseDTO(Movie movie)
        {
            Status = "Success";
            Datas = new DataMovieDTO(movie);
        }

        public static List<MovieResponseDTO> FromRepository(IEnumerable<Movie> movies)
        {
            var results = new List<MovieResponseDTO>();
            foreach (var movie in movies)
                results.Add(new MovieResponseDTO(movie));
            return results;
        }

        public static MovieResponseDTO FromARepository(Movie movie)
        {
            MovieResponseDTO result = new MovieResponseDTO(movie);
            return result;
        }
    }
}