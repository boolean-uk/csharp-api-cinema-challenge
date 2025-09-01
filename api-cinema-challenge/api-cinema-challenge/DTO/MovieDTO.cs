namespace api_cinema_challenge.Dtos
{
    public record CreateMovie(string Title, string Rating, string Description, int RuntimeMins);
    public record UpdateMovie(string Title, string Rating, string Description, int RuntimeMins);
    public record MovieDto(int Id, string Title, string Rating, string Description, int RuntimeMins, DateTime CreatedAt, DateTime UpdatedAt);
}
