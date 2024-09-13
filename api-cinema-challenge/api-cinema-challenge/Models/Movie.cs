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

        [Column("runtimemins")]
        public int RuntimeMins { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        List<Screening> Screenings { get; set; }
    }
}
