using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class MoviePost
    {
        public string title { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public IEnumerable<ScreeningPost> screenings { get; set; }
    }
}
