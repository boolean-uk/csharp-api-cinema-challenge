using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    [Table("movie")]
    public class Movie
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [Required]
        [Column("title")]
        public string? Title { get; set; }

        [Required]
        [Column("rating")]
        public string? Rating { get; set; }

        [Required]
        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [Column("runtimemins")]
        public int RuntimeMins { get; set; }

        public ICollection<Screening>? Screenings { get; set; }
    }

}
