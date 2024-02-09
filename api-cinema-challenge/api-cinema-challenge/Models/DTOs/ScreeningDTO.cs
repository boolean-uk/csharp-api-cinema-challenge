using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningDTO
    {
        public string MovieName { get; set; }
        public int ScreenNum { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }

    }
}
