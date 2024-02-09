using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api_cinema_challenge.Models
{
    public class Screening
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("screen_number")]
        public int ScreenNumber { get; set; } 

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set;}

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set;}


        [ForeignKey("movie_id")]
        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
