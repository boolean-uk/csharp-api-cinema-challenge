using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.TransferModels.Movies
{
    public class MovieDTO(int Id, string Title, string Rating, string Description, int Runtime, DateTime Created, DateTime Updated)
    {
        public int Id { get; set; } = Id;

        public string Title { get; set; } = Title;

        public string Rating { get; set; } = Rating;

        public string Description { get; set; } = Description;

        public int RuntimeMins { get; set; } = Runtime;

        public string CreatedAt { get; set; } = Created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = Updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }
}
