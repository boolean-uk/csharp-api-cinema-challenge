using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DatabaseModels
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
        [Column("runtimeMins")]
        public int RuntimMins { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

    }
}
