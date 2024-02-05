using api_cinema_challenge.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime")]
        public int Runtime { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

        public MovieDTO ToDTO()
        {
            var movieDTO = new MovieDTO
            {
                Id = Id,
                Title = Title,
                Rating = Rating,
                Description = Description,
                Runtime = Runtime,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };

            return movieDTO;
        }
    }
}
