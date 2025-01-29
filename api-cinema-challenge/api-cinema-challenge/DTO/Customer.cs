namespace api_cinema_challenge.DTO
{
    public record CustomerPost(string FirstName, string LastName, string Email, string Phone);
    public record CustomerPut(string? FirstName, string? LastName, string? Email, string? Phone);
    public record CustomerView(int Id, string FullName, string Email, string Phone, DateTime CreatedAt, DateTime UpdatedAt);
}
