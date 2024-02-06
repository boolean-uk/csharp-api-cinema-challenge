using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Application.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }
        [Column("created_at", TypeName = "date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at", TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }
    }
}
