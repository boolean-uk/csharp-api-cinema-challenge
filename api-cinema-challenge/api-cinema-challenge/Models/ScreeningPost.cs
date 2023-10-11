using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class ScreeningPost
    {
        [Required]
        public required int screenNumber { get; set; }
        [Required]
        public required int capacity { get; set; }
        [Required]
        public required DateTime startsAt { get; set; }
    }
}
