using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie : DbEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("runtime_minutes")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        public List<Screening> Screenings { get; set; }
    }
}
