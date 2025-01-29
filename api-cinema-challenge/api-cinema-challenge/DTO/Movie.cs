namespace api_cinema_challenge.DTO
{
    public record MoviePost(
        string Title, string Rating, string Description, int Runtime,
        string ReleaseDate, List<ScreeningMoviePost> Screenings);
    public record MoviePut(
        string? Title, string? Rating, string? Description, int? Runtime,
        string? ReleaseDate);
    public record MovieView(
        int Id, string Title, string Rating, string Description, int Runtime, DateTime ReleaseDate, 
        IEnumerable<ScreeningScreen> Screenings, DateTime CreatedAt, DateTime UpdatedAt);
    public record MovieSimple(
        string Title, string Rating, int Runtime);
}
