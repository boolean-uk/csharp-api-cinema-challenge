using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Input
{
    public class MovieInput
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public List<ScreeningInput> Screening { get; set; }
    }
}
