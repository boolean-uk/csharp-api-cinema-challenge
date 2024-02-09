namespace api_cinema_challenge.Models.Posts
{
    public class ScreeningPut
    {
        public required int? ScreenNumber { get; set; }
        public required int? Capacity { get; set; }
        public required int? MovieId { get; set; }
        public required DateTime? StartsAt { get; set; }
    }
}
