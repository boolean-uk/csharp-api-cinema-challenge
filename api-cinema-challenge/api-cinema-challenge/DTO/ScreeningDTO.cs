using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO : BaseDTO
    {
        public ScreeningDTO(Screening screening) 
        { 
            Id = screening.Id;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;

            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
        }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
