namespace api_cinema_challange.Models
{
    public record ScreeningPostPayload(int movie_id, int screen_number, int capacity, DateTime startsAt);
}