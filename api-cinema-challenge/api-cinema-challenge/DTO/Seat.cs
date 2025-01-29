namespace api_cinema_challenge.DTO
{
    public record SeatPost(string SeatType);
    public record SeatView(int Id, int ScreenId, ScreenInternal Screen, string SeatType);
    public record SeatInternal(int Id, string SeatType);
}
