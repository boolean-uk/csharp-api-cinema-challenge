using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api_cinema_challenge.Models.TransferModels.Screenings;
using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Models.TransferModels.Movies
{
    public class MovieWithScreeningDTO(int Id, string Title, string Rating, string Description, int Runtime, DateTime Created, DateTime Updated, IEnumerable<Screening> screenings)
    {
        public int MovieId { get; set; } = Id;

        public string Title { get; set; } = Title;

        public string Rating { get; set; } = Rating;

        public string Description { get; set; } = Description;

        public int RuntimeMinutes { get; set; } = Runtime;

        public string CreatedAt { get; set; } = Created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = Updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public ICollection<ScreeningDTO> Screenings { get; set; } = screenings.Select(x => new ScreeningDTO(x.ScreeningId, x.ScreenNumber, x.Capacity, x.Starts, x.CreatedAt, x.UpdatedAt)).ToList();
    }
}
