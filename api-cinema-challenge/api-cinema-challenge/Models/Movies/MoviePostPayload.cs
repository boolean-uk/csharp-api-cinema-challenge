namespace api_cinema_challenge.Models
{
    public record MoviePostPayload(string title, string rating, string description, int runtimeMins, List<MovieScreeningPostPayload>? screenings);

    public record MovieScreeningPostPayload(int screen_number, int capacity, DateTime startsAt);

}