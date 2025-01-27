namespace api_cinema_challenge.DTO
{
    public record ScreenPost(string Name, int Capacity);
    public record ScreenView(int Id, string Name, int Capacity);
    public record ScreenInternal(int Id, string Name, int Capacity);
}
