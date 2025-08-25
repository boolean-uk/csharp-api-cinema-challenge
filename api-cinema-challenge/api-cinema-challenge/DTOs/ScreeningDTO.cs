using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs
{
    public class ScreeningDTO
    {
        public int MovieId { get; set; }
        public MovieDTO Movie { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartsAt { get; set; }

    }
}
