using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Required] public int Id { get; set; }
        [Required] public int screenNumber { get; set; }
        [Required] public int capacity { get; set; }
        [Required] public DateTime startsAt { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
