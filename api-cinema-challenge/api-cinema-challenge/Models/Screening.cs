using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening : BaseClass
    {
        [ForeignKey(nameof(Movie))]
        public int Id { get; set; }
        [Key]
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        [Key]
        public DateTime StartsAt { get; set; }
    }
}
