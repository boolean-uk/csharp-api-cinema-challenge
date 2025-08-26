using api_cinema_challenge.DOTs.ScreeningDTOs;
using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("screening_id")]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("movie_id")]
        public int MovieId { get; set; }
        [Column("screening_tickets")]
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        [Column("screening_movie")]
        public Movie Movie { get; set; }

        public DateTime CreatedAt {  get; set; }
        public DateTime UpdatedAt { get; set; }
        public Screening()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        public Screening(ScreeningPost newScreening)
        {
            ScreenNumber = newScreening.ScreenNumber;
            Capacity = newScreening.Capacity;
            StartsAt = newScreening.StartAt;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
