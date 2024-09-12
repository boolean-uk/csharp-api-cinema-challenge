using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Movie
{
    [Table("MOVIE")]
    public class Movie
    {
        [Key]
        [Required]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TITLE")]
        public string Title { get; set; }
        [Column("RATING")]
        public string rating { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("RUNTIME")]
        public int runtimeMins { get; set; }
        [Column("SCREENINGS")]
        public List<Screening.Screening> Screenings { get; set; }
        [Column("CREATEDAT")]
        public DateTime createdAt { get; set; }
        [Column("UPDATEDAT")]
        public DateTime updatedAt { get; set; }
    }
}
