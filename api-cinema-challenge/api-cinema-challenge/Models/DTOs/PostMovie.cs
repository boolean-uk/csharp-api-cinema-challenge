using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs
{
    public class PostMovie
    {
        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

    }
}
