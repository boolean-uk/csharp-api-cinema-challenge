using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie : AbstractModel
    {
        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("rating")]
        public string Rating { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("runtime_minutes")]
        public int Runtime { get; set; }
    }
}
