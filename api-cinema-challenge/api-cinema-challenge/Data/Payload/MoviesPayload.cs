
namespace api_cinema_challenge.Data.Payload {

    public record CreateMoviePayload(string Title, string Rating, string Description, string RuntimeMins);

    public record UpdateMoviePayload(string? Title, string? Rating, string? Description, string? RuntimeMins);
    
}