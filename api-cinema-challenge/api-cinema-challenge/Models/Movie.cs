using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Title")]
        public string Title { get; set; }
        [Required]
        [Column("Rating")]
        public string Rating { get; set; }
        [Required]
        [Column("Description")]
        public string Description { get; set; }
        [Required]
        [Column("RuntimeMins")]
        public int RuntimeMins { get; set; }
        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

        public List<Screening>? Screenings { get; set; }

    }
}
