using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningResponseDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ScreeningResponseDTO(Screening screening) 
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }

        public static List<ScreeningResponseDTO> FromRepository(IEnumerable<Screening> screenings)
        {
            var results = new List<ScreeningResponseDTO>();
            foreach (var screening in screenings)
                results.Add(new ScreeningResponseDTO(screening));
            return results;
        }

        public static ScreeningResponseDTO FromARepository(Screening screening)
        {
            ScreeningResponseDTO result = new ScreeningResponseDTO(screening);
            return result;
        }
    }
}
