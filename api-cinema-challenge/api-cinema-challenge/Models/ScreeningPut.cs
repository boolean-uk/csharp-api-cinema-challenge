using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class ScreeningPut
    {
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime? startsAt { get; set; }
    }
}
