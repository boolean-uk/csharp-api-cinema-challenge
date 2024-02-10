namespace api_cinema_challenge.Models
{
    public record UpdateMoviePayload
    (
        string? title,
        string? rating,
        string? description,
        int? runtime
    );
}
