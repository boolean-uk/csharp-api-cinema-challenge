namespace api_cinema_challenge.Models
{
    public record CustomerUpdatePayload(int id, string Name, string Email, int Phone);
}