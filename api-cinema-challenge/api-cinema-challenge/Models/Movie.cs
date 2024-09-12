using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtimeMinutes")]
        public int RuntimeMins { get; set; }

        [Column("created")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated")]
        public DateTime UpdatedAt { get; set; }
        
    }
}
