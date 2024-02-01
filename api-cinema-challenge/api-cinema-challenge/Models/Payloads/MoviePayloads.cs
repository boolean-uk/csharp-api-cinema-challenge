namespace api_cinema_challenge.Models.Payloads
{
    public class MoviePayloads
    {

        public record MoviePostPayload(string title, string rating, string description, int runtime);
        public record MoviePutPayload(string? title, string? rating, string? description, int? runtime);
    }
}
