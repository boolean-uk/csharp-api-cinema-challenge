namespace api_cinema_challenge.DTO
{
    public record ScreenPost(string Name, int Capacity);
    public record ScreenView(int Id, string Name, int Capacity, IEnumerable<SeatInternal> Seats);
    public record ScreenInternal(int Id, string Name, int Capacity);
    public record ScreenSimple(int Id, string Name);
    public record ScreenName(string Name);
}
