namespace api_cinema_challenge.Models
{
    public record UpdateUserPayload
    (
        string? name,
        string? email,
        string? phoneNumber
    );
}
