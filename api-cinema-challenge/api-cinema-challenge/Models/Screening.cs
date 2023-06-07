using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening
    {

        public int Id { get; set; }


        public int screenNumber { get; set; }
        [ForeignKey("Movie")]
        public int movieId { get; set; }
        public Movie movie { get; set; }
        public int capacity { get; set; }


        public DateTime startsAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


    }
}
