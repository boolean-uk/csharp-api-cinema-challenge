using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.Payload { 

    public record UpdateCustomerPayload(string? Name, string? Email, string? Phone);
    public record CreateCustomerPayload(string Name, string Email, string Phone);
}