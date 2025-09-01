namespace api_cinema_challenge.Dtos
{
    public record CreateCustomer(string Name, string Email, string Phone);
    public record CustomerDto(int Id, string Name, string Email, string Phone, DateTime CreatedAt, DateTime UpdatedAt);
}
