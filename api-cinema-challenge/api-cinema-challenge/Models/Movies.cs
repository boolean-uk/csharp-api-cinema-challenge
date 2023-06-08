using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RunTime { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //[ForeignKey("Screenings")]
        //public int ScreeningId { get; set; }
        //public Screenings Screenings { get; set; }

    }
}
