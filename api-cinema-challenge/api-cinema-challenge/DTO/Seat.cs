namespace api_cinema_challenge.DTO
{
    public record SeatPost(string SeatType, int ScreenId);
    public record SeatView();
    public record SeatInternal(int Id, string SeatType);
}
