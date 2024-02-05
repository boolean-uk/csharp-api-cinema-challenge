using api_cinema_challenge.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set;}
        [Column("capacity")]
        public int Capacity { get; set;}
        [Column("movie_id")]
        public int MovieId { get; set;}
        public Movie Movie { get; set;}
        [Column("starts_at")]
        public DateTime StartsAt { get; set;} = DateTime.UtcNow;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ScreeningDTO ToDTO()
        {
            var screeningDTO = new ScreeningDTO
            {
                Id = Id,
                ScreenNumber = ScreenNumber,
                Capacity = Capacity,
                StartsAt = StartsAt,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };

            return screeningDTO;
        }
    }
}
