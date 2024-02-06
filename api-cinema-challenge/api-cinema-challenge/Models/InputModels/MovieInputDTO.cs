namespace api_cinema_challenge.Models.InputModels
{
    public class MovieInputDTO(string Title, string Rating, string Description, int Runtime)
    {
        public string Title { get; set; } = Title;

        public string Rating { get; set; } = Rating;

        public string Description { get; set; } = Description;

        public int RuntimeMinutes { get; set; } = Runtime;

    }
}
