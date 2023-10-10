using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Required] public int Id { get; set; }
        [Required] public int screenNumber { get; set; }
        [Required] public int capacity { get; set; }
        [Required] public DateTime startsAt { get; set; }
    }
}
