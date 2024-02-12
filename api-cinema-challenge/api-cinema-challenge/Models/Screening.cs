using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column("id")] public int Id { get; set; }
        [Column("movie_id")] [ForeignKey("movie_id")] public int MovieId { get; set; }
        [Column("screen_num")] public int ScreenNum { get; set; }
        [Column("capacity")] public int Capacity { get; set; }
        [Column("starts_at")] public DateTime StartTime { get; set; }
        [Column("date_created")] public DateTime TimeCreated { get; set; }
        [Column("date_updated")] public DateTime TimeUpdated { get; set; }

        [JsonIgnore] public Movie PlayingMovie { get; set; }
    }
}
