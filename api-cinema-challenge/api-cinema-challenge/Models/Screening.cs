using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    [PrimaryKey("Id")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("fk_movie_id")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        [Column("fk_silver_screen_id")]
        [ForeignKey("SilverScreen")]
        public int SilverScreenId { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
