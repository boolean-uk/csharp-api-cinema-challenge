public class BookingDto
{
    public int CustomerId { get; set; }
    public int MovieId { get; set; }
    public DateTime BookedAt { get; set; }
    public string? CustomerName { get; set; }
    public string? MovieTitle { get; set; }
}
