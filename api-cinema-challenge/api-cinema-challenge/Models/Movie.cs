using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Column("title")]
        public string Title {  get; set; }

        [Column("rating")]
        public string Rating {  get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtimeMins")]
        public int RuntimeMins { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Column("Screenings")]
        public List<Screening>screenings { get; set; } = new List<Screening> ();
    }
}
