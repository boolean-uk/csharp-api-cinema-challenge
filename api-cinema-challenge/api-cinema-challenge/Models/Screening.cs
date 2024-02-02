using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set;}
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class ScreeningResponseDTO
    {
        public int id { get; set; }
        public MovieDTO movie { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ScreeningResponseDTO(Screening screening)
        {
            id = screening.Id;
            movie = new MovieDTO(screening.Movie);
            screenNumber = screening.ScreenNumber;
            capacity = screening.Capacity;
            startsAt = screening.StartsAt;
            createdAt = screening.CreatedAt;
            updatedAt = screening.UpdatedAt;
        }
    }

    public class ScreeningOutput
    {
        public string status { get; }
        public ScreeningResponseDTO data { get; }
        public ScreeningOutput(string status, Screening data)
        {
            this.status = status;
            this.data = new ScreeningResponseDTO(data);
        }
    }

    public class ScreeningListOutput
    {
        public string status { get; }
        public ICollection<ScreeningResponseDTO> data { get; }
        public ScreeningListOutput(string status, IEnumerable<Screening> screenings)
        {
            this.status = status;
            data = new List<ScreeningResponseDTO>();
            foreach (Screening screening in screenings)
            {
                data.Add(new ScreeningResponseDTO(screening));
            }
        }
    }
    public record ScreeningPayload(int screenNumber, int capacity, DateTime startsAt);
}
