using System.Runtime.InteropServices;

namespace api_cinema_challenge.Models.Dtos
{
    public class CreateMovieDto
    {
        public string title { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public ICollection<CreateScreeningDto>? Screenings { get; set; }
    }
}
