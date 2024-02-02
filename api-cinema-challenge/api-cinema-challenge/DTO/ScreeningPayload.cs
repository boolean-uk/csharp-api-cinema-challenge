namespace api_cinema_challenge.DTO
{
    public record ScreeningPayload(int screenNumber, int capasity, string startsAt, int movieID);
}