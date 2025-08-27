public class Booking
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;

    public DateTime BookedAt { get; set; } = DateTime.UtcNow;
}