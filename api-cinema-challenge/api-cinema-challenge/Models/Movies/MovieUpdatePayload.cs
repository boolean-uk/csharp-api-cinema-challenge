namespace api_cinema_challange.Models
{
    public record MovieUpdatePayload(int id, string title, string rating, string description, int runtimeMins);
}