using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings
{
    public class ScreeningOutputDTO
    {
        public ScreeningOutputDTO(Screening screening, int screenNumber, int capacity)
        {
            Id = screening.Id;
            ScreenNumber = screenNumber;
            Capacity = capacity;
            StartsAt = screening.StartsAt.ToString("yyyy-MM-ddTHH:mm:ss");
            CreatedAt = screening.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = screening.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
        }
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public string StartsAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set;}
    }
}
