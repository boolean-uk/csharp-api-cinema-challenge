
namespace api_cinema_challenge.Data.Payload {

    public record CreateScreeningPayload(int ScreenNumber, int Capacity, DateTime StartsAt, DateTime EndsAt, int MovieId, List<CreateSeatPayload> Seats);

    public record CreateSeatPayload(string SeatRow, int SeatNumber);
}