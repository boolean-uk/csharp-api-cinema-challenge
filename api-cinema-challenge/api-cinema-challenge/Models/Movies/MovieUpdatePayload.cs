namespace api_cinema_challenge.Models
{
    public record MovieUpdatePayload(int id, string title, string rating, string description, int runtimeMins);
}