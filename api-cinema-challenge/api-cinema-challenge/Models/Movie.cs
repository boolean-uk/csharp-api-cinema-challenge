using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        public int Id { get; internal set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime")]
        public int Runtime { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; internal set; }
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; internal set; }
        [JsonIgnore]
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
