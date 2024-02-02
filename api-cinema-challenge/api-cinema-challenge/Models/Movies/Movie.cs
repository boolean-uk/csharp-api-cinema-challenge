using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Data;

namespace api_cinema_challange.Models
{
    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        // Navigation property for the one-to-many relationship
        public List<Screening> Screenings { get; set; }
    }
}