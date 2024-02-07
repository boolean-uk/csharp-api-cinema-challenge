using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings
{
    [Table("screeings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("auditoium_id")]
        [ForeignKey("AuditoriumId")]
        public int AuditoriumId { get; set; }
        public Auditorium Auditorium { get; set; }

        [Column("movie_id")]
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
    }
}
