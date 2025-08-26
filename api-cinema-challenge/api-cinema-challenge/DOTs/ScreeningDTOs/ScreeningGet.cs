using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.ScreeningDTOs
{
    public class ScreeningGet
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ScreeningGet(Screening screening) 
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }
    }
}
