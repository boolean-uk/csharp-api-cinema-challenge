using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }

        //public List<ScreeningDTO> Screenings { get; set; }

    }
}
