namespace api_cinema_challenge.DTO
{
    public record TicketPost(int SeatId);
    public record TicketView(int Id, SeatInternal Seat, DateTime CreatedAt, DateTime UpdatedAt);
}
