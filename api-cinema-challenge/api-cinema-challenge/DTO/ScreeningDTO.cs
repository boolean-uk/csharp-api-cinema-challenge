using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public ScreeningDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartTime = screening.StartTime;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }

    }
}
