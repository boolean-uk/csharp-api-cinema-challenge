using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningAllDetailsDTO
    {
        public int Id { get; set; }
        //[Column("screen_numbers")]
        public int ScreenNumber { get; set; }
        //[Column("capacities")]
        public int Capacity { get; set; }
        //[Column("starts_at")]
        public DateTime StartsAt { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ScreeningAllDetailsDTO(Screening screening) {
            Id = screening.ScreeningId;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
            
        }
    }
}
