using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public record MoviePostPayload(string Title, string Rating, string Description, int Runtime);
    public record MovieUpdatePayload(string? Title, string? Rating, string? Description, int? Runtime);
    [Table("movies")]
    public class Movies
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime")]
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Movies()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
