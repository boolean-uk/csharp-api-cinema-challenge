using api_cinema_challenge.Models.PureModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.TransferModels.Screenings
{
    public class ScreeningDTO(int Id, int ScreenNumber, int Capacity, DateTime Starts, DateTime Created, DateTime Updated)
    {
        public int ScreeningId { get; set; } = Id;

        public int ScreenNumber { get; set; } = ScreenNumber;

        public int Capacity { get; set; } = Capacity;

        public string StartsAt { get; set; } = Starts.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string CreatedAt { get; set; } = Created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = Updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }
}
