using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("screen_numbers")]
        public int ScreenNumber { get; set; }
        [Column("capacities")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public string StartsAt { get; set; }


        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
