using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("screenNumber")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("startsAt")]
        public DateTime StartsAt { get; set; }
        [Column("movie_id"), ForeignKey("Movie"), JsonIgnore]
        public int MovieId { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public List<Ticket> Tickets { get; set; }
    }
}
