using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace api_cinema_challenge.Models
{
    [Table("movie")]
    public class Movie
    {
        [Key, Required, Column("id")]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public int RuntimeMins { get; set; }
        public IEnumerable<Screening> Screenings { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
