using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public string rating { get; set; }
        [Column("createdAt", TypeName = "timestamp")]
        public DateTime createdAt { get; set; } = DateTime.Now;
        [Column("updatedAt", TypeName = "timestamp")]
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public List<Screening> screenings { get; set; }
    }
}
