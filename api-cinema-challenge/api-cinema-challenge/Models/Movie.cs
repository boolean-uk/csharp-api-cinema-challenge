using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("rating")]
        public string Rating { get; set; }

        [Required]
        [Column("decription")]
        public string Description { get; set; }

        [Required]
        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
