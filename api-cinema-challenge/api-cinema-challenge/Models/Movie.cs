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
        [Column("runtimemins")]
        public int RuntimeMins { get; set; }
        [Column("createdat")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
