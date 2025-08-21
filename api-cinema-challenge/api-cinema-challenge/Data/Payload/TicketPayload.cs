
namespace api_cinema_challenge.Data.Payload {

    public record CreateTicketPayload(List<CreateSeatPayload> seats);

}