using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModels
{
    public class ScreeningDTO
    {
        public int id {  get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public ScreeningDTO(Screening screening)
        {
            this.id = screening.Id;
            this.screenNumber = screening.ScreenNumber;
            this.capacity = screening.Capacity;
            this.startsAt = screening.StartsAt;
            this.createdAt = screening.CreatedAt;
            this.updatedAt = screening.UpdatedAt;
        }
    }
}
