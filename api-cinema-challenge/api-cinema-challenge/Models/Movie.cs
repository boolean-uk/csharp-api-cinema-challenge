using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("movie")]
    [PrimaryKey("Id")]
    public class Movie
    {
        [Column("movie_id")]
        public int Id { get; set; }
        [Column("movie_title")]
        public string Title { get; set; }
        [Column("movie_rating")]
        public string Rating { get; set; }
        [Column("movie_description")]
        public string Description { get; set; }
        [Column("movie_runtime")]
        public int RuntimeMins { get; set; }
        [Column("movie_created_date")]
        public DateTime CreatedAt { get; set; }
        [Column("movie_updated_date")]
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public ICollection<Screening> Screenings { get; set; }
    }
}
