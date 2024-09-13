using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screening")]
    public class Screening
    {
        [Column("Id")]
        public int Id { get; set; }
        [ForeignKey("Screen_Id")]
        public int ScreenId { get; set; }
        [ForeignKey("Movie_Id")]
        public int MovieId { get; set; }
        [Column("ScreeningTime")]
        public DateTime ScreeningTime { get; set; }

        public Movie Movie { get; set; }

        public Screen Screen { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
