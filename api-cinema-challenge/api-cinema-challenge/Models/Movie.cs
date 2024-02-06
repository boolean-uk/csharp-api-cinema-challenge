using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("created_at", TypeName = "Date")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "Date")]
        public DateTime? UpdatedAt { get; set; }

    
    }
}
