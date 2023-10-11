using api_cinema_challenge.Models.Screen;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Movie
{
    [NotMapped]
    public class MovieScreenCreate
    {
        public string title { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public IEnumerable<ScreenPost> screenings { get; set; }
    }
}
