using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDto
    {
        public int Id { get; set; }
        public int ScreanNumber { get; set; }
        public int Capacity { get; set; }
        //public int MovieId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt {  get; set; } 


        public ScreeningDto(Screening screening) 
        { 
            Id = screening.Id;
            ScreanNumber = screening.ScreanNumber;
            Capacity = screening.Capacity;
            //MovieId = screening.MovieId;
            StartAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;

        }

    }
}
