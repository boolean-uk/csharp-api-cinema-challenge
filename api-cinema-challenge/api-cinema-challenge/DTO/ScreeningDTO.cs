using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }
        public DateTime startsAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
