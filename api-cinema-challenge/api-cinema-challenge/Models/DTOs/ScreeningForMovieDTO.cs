using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningForMovieDTO
    {
      
        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }

      
    }
}
