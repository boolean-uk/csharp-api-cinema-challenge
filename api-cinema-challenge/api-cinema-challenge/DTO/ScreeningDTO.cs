using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ScreeningDTO(Screening screening) 
        { 
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }

    }
}
