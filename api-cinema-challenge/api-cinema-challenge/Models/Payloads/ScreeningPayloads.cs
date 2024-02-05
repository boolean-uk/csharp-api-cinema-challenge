namespace api_cinema_challenge.Models.Payloads
{
    public class ScreeningPayloads
    {

        public record ScreeningPostPayload(int screenNumber, int capacity, DateTime startsAt);
    }
}
