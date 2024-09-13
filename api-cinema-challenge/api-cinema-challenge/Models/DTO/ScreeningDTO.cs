using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }

        public int Capacity { get; set; }
        public int ScreenNumber { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime CreatedAT { get; set; }

        public DateTime UpdatedAT { get; set; }



    }
}
