using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("MovieName")]
        public string MovieName { get; set; }
        [Column("Rating")]
        public string Rating { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("RuntimeMins")]
        public int RuntimeMins { get; set; }
        [Column("CreatedAt")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}
