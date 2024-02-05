namespace api_cinema_challenge.Models
{
    public record ScreeningPostPayload(int movie_id, int screen_number, int capacity, DateTime startsAt);
}