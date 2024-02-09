using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public ScreeningDTO(Screening screening) { 
        
            Id = screening.Id;
            Number = screening.Number;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        
        }
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime UpdatedAt { get; set; }
    }
}
