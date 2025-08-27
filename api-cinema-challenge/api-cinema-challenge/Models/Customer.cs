public class Customer
{
    public int Id { get; set; }

    // Login-related
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    // Profile-related
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phonenumber { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public List<Booking> Bookings { get; set; } = new();
}
