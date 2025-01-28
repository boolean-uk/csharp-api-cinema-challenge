namespace api_cinema_challenge.Models;

public class Screening : BaseEntity
{
    public int Id { get; set; }
    public int ScreenNumber { get; set; }
    public int Capacity { get; set; }
    public DateTime StartsAt { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public List<Ticket>? Tickets { get; set; }
}