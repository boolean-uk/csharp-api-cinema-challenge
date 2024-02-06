using api_cinema_challenge.Models.PureModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.InputModels
{
    public class ScreeningInputDTO(int MovieId, int ScreenNumber, int Capacity, string startsAt )
    {
        public int MovieId { get; set; } = MovieId;

        public int ScreenNumber { get; set; } = ScreenNumber;

        public int Capacity { get; set; } = Capacity;

        public DateTime Starts { get; set; } = DateTime.Parse(startsAt);

    }
}
