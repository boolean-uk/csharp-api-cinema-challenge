public class Screening
{
    public int Id { get; set; }         
    public int MovieId { get; set; }     
    public Movie Movie { get; set; } = null!; // Navigation property!
    public int ScreenNumber { get; set; }
    public int Capacity { get; set; }
    public DateTime StartsAt { get; set; }
}
