namespace api_cinema_challenge.DTO;

public class TicketResponse
{
    public int Id { get; set; }
    public int NumSeats { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}