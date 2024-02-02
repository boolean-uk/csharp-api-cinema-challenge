using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challange.Models
{
    public class MovieResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public MovieResponseDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }

        public static List<MovieResponseDTO> FromRepository(IEnumerable<Movie> patients)
        {
            var results = new List<MovieResponseDTO>();
            foreach (var patient in patients)
            {
                results.Add(new MovieResponseDTO(patient));
            }
            return results;
        }

        public static MovieResponseDTO FromRepository(Movie patient)
        {
            return new MovieResponseDTO(patient);
        }

    }
}