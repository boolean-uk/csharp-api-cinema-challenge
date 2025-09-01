namespace api_cinema_challenge.Dtos
{
    public record CreateScreening(int ScreenNumber, int Capacity, DateTime StartsAt);
    public record ScreeningDto(int Id, int ScreenNumber, int Capacity, DateTime StartsAt, DateTime CreatedAt, DateTime UpdatedAt);
}
