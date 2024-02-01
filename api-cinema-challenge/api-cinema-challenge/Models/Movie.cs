using System.Net.Mail;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("movie_id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; } // (DateTime.Today.Date.ToString("dd-MM-yyyy HH:mm:ss")
        public DateTime UpdatedAT { get; set; }
        public ICollection<Screenings> Screenings { get; set;} = new List<Screenings>();
    }
}
