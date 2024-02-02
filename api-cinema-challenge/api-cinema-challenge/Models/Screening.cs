using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    //DTO
    public class ScreeningResponseDTO
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int Capacity { get; set; }
        public int Screen { get; set; }
        public DateTime StartTime { get; set; }

        public ScreeningResponseDTO(Screening screening)
        {
            ID = screening.Id;
            MovieId = screening.MovieId;
            Capacity = screening.Capacity;
            Screen = screening.ScreenNumber;
            StartTime = screening.StartTime;
        }
    }
}