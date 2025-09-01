namespace api_cinema_challenge.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateTime CreatedAt { get; set; } // UTC
        public DateTime UpdatedAt { get; set; } // UTC
    }
}
