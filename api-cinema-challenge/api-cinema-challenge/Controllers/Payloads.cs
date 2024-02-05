namespace api_cinema_challenge.Controllers
{
    public record TicketPostPayload(int SeatNr, int ScreeningId, int CustomerId);
    public record ScreeningPostPayload(int ScreenNr, int Capacity, DateTime StartsAt);
    public record MoviePostPayload(string Title, string Rating, string Description, int Runtime);
    public record MovieUpdatePayload(string? Title, string? Rating, string? Description, int? Runtime); 
    public record CustomerPostPayload(string Name, string Email, string PhoneNr, int ScreeningId);
    public record CustomerUpdatePayload(string? Name, string? Email, string? PhoneNr, int? ScreeningId);
}
