using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO.DTO_Screening
{
    public class ScreeningDTO
    {
        public int id { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public ScreeningDTO(Screening screening)
        {
            id = screening.id;
            screenNumber = screening.screenNumber;
            capacity = screening.capacity;
            startsAt = screening.startsAt;
            createdAt = screening.createdAt;
            updatedAt = screening.updatedAt;
        }


    }
}