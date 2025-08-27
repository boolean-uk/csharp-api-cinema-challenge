public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Rating { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string RuntimeMins { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public List<Booking> Bookings { get; set; } = new();
}
