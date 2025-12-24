using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Rating { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int RunTimeMinutes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public MovieDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RunTimeMinutes = movie.RunTimeMinutes;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }


        public static List<MovieDTO> FromRepository(IEnumerable<Movie> movies)
        {
            var results = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                results.Add(new MovieDTO(movie));
            }
            return results;
        }
    }

    public class MovieResponseDTO{
        public string status { get;}
        public IEnumerable<MovieDTO> data { get; set; }

        public MovieResponseDTO(string status, IEnumerable<MovieDTO> data){
            this.status = status;
            this.data = data;
        }
    }

    public class MovieListResponseDTO{
        public string status { get;}
        public List<MovieDTO> data { get; set; }

        public MovieListResponseDTO(string status, IEnumerable<Movie> data){
            this.status = status;
            this.data = new List<MovieDTO>();
            foreach (var movie in data){
                this.data.Add(new MovieDTO(movie));
            }
        }
    }

}