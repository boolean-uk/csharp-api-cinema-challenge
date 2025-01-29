using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs
{
    public class MoviePOST
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public IEnumerable<ScreeningPOST>? Screenings { get; set; }
    }
}
