using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs
{
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capasity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartsAt { get; set; }

    }
}
