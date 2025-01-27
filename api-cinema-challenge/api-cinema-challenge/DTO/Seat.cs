namespace api_cinema_challenge.DTO
{
    public record SeatPost(string SeatType, int ScreenId);
    public record SeatView(int Id, ScreenInternal Screen, string SeatType);
    public record SeatInternal(int Id, string SeatType);
}
