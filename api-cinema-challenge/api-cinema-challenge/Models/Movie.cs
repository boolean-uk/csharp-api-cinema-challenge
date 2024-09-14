using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Helpers;

namespace api_cinema_challenge.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Column("MovieId")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Rating")]
        public Rating Rating { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
