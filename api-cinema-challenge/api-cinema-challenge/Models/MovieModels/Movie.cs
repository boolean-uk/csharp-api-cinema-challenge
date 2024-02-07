using api_cinema_challenge.Models.ScreeningModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.MovieModels
{
    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("runtime")]
        public string Runtime { get; set; }

        public ICollection<Screening> Screenings { get; set; }
    }
}
