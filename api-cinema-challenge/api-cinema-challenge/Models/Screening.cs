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

        [Column("screen_name")]
        public string ScreenName { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        //public Movie movie { get; set; }

    }

    public class ScreeningResponseDTO
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public string Screen { get; set; }
        public DateTime StartTime { get; set; }

        public ScreeningResponseDTO(Screening screening)
        {
            ID = screening.Id;
            MovieId = screening.MovieId;
            Screen = screening.ScreenName;
            StartTime = screening.StartTime;

        }
    }
}