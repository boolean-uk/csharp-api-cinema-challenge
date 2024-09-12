using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsScreening
{
    public class ScreeningData
    {
        public int id { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public ScreeningData(Screening screening)
        {
            id = screening.Id;
            screenNumber = screening.ScreenNumber;
            capacity = screening.Capacity;
            startsAt = screening.StartsAt;
            createdAt = screening.CreatedAt;
            updatedAt = screening.UpdatedAt;
        }
    }
}
