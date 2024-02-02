using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challange.Models
{
    public class ScreeningResponseDTO
    {
        public int Id { get; set; }
        public MovieResponseDTO Movie { get; set; }
        public int screenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public ScreeningResponseDTO(Screening screening)
        {
            Id = screening.Id;
            Movie = new MovieResponseDTO(screening.Movie);
            screenNumber = screening.screenNumber;
            Capacity = screening.Capacity;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }

        public static List<ScreeningResponseDTO> FromRepository(IEnumerable<Screening> screenings)
        {
            var results = new List<ScreeningResponseDTO>();
            foreach (var screening in screenings)
            {
                results.Add(new ScreeningResponseDTO(screening));
            }
            return results;
        }       

         public static ScreeningResponseDTO FromRepository(Screening screening)
        {
            return new ScreeningResponseDTO(screening);
        }        
    }
}