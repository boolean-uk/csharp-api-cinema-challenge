using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("title")] 
        public string Title { get; set; }

        [Required]
        [Column("rating")]
        public string Rating { get; set; }

        [Required]
        [Column("description")] 
        public string Description { get; set; }

        [Required]
        [Column("runtime_minutes")] 
        public int RuntimeMins { get; set; }

        [Column("created_at")] 
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public List<Screening> Screenings { get; set; } // One-to-Many with Screenings
    }
}
