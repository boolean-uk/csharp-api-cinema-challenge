namespace api_cinema_challenge.DTO
{
    public record ScreeningPost(int ScreenId, int MovieId, string StartingAt);
    public record ScreeningMoviePost(int ScreenId, string StartingAt);
    public record ScreeningView(int Id, ScreenInternal Screen, DateTime StartingAt, DateTime CreatedAt, DateTime UpdatedAt);
    public record ScreeningScreen(ScreenInternal Screen, DateTime StartingAt);
}
