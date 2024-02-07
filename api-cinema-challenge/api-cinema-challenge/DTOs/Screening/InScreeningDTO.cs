using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs.Screening
{
    public class InScreeningDTO
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; } 
        public DateTime StartAt { get; set; }
    }
}
