using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Screening
{
    [NotMapped]
    public class ScreeningPost
    {
        [Required]
        public int ScreenNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public DateTime StartsAt { get; set; }
    }
}
