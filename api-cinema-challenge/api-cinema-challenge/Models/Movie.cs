using api_cinema_challenge.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie : ParentModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public MovieRating Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtimemins")]
        public int RuntimeMins { get; set; }

        public List<Screening> Screenings { get; set; }
    }
}
