using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    [PrimaryKey("Id")]
    public class Screening
    {
        [Column("screening_id")]
        public int Id { get; set; }
        [Column("screening_screennumber")]
        public int ScreenNumber { get; set; }
        [Column("screening_capacity")]
        public int Capacity { get; set; }
        [Column("screening_start_date")]
        public DateTime StartsAt { get; set; }
        [Column("screening_created_date")]
        public DateTime CreatedAt { get; set; }
        [Column("screening_updated_date")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        public int MovieId {  get; set; }
        public Movie Movie { get; set; }

        [JsonIgnore]
        public ICollection<Ticket> Tickets { get; set; }
    }
}
