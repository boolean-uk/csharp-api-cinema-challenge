using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id {  get; set; }
        public int Capacity { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }


        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public Screening() { }
        public Screening(PostScreening screening)
        {
            Capacity = screening.Capacity;
            ScreenNumber = screening.ScreenNumber;
            StartsAt = screening.StartsAt;
            CreatedAt = DateTime.UtcNow;
            UpdateAt = DateTime.UtcNow;
        }
    }

    public class ScreeningDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public ScreeningDto(Screening screening)
        {
            Id = screening.Id;
            Capacity = screening.Capacity;
            ScreenNumber = screening.ScreenNumber;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdateAt = screening.UpdateAt;
        }
    }

    public class GetScreeningDto : ScreeningDto
    {
        public int MovieId { get; set; }
        public MovieDto Movie { get; set; }

        public GetScreeningDto(Screening screening) : base(screening) 
        { 
            MovieId = screening.MovieId;
            Movie = new MovieDto(screening.Movie);
        }
    }

    public class PostScreening
    {
        public int Capacity { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
