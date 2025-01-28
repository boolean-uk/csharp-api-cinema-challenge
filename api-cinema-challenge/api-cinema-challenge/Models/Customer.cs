namespace api_cinema_challenge.Models;

public class Customer : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<Ticket>? Tickets { get; set; }
}