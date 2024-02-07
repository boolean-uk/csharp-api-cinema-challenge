using api_cinema_challenge.Models.InputModels.Screening;

namespace api_cinema_challenge.Models.InputModels.Movie
{
    public class MoveInputDTO(string Title, string Rating, string Description, int RuntimeMins)
    {
        public string Title { get; set; } = Title;

        public string Rating { get; set; } = Rating;

        public string Description { get; set; } = Description;

        public int RuntimeMins { get; set; } = RuntimeMins;
    }
}
