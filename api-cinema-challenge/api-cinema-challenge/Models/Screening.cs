using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int movieId { get; set; }
        public int capacity { get; set; }
        public int screenNumber { get; set; }
        [Column("startsAt", TypeName = "timestamp")]
        public DateTime startsAt { get; set; }
        [Column("createdAt", TypeName = "timestamp")]
        public DateTime createdAt { get; set; } = DateTime.Now;
        [Column("updatedAt", TypeName = "timestamp")]
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public Movie Movie { get; set; }
    }
}
