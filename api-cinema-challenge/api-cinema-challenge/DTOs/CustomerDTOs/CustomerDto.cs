namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
