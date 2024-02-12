using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO
{
    public class ScreeningServerDto
    {
        public int Id { get; set; }

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime CreatedAt { get; set; }
      
        public DateTime UpdatedAt { get; set; }
    }
}
