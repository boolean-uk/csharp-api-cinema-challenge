using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{

    

    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int id { get; set; }

        [Column("title")]
        public string title { get; set; }
        [Column("movie_rating")]
        public string rating { get; set; }
        [Column("movie_description")]
        public string Description { get; set; }
        [Column("runtime_in_minutes")]
        public int runtimeMins { get; set; }
        [Column("creatd_at")]
        public DateTime createdAt { get; set; }

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}
