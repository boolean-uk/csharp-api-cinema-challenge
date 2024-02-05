using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("id")]
        public int MovieId { get; set; }
        [Column("titles")]
        public string Title { get; set; }
        [Column("ratings")]
        public string Rating { get; set; }
        [Column("descriptions")]
        public string Description { get; set; }
        [Column("runtime_in_mins")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime Created_at { get; set; }
        [Column("updated_at")]
        public DateTime Updated_at { get; set; }

        // internal
        public ICollection<Screening> Screenings { get; set; }
    }
}
