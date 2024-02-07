namespace api_cinema_challenge.Models.TransferModels.Tickets
{
    public class TicketDTO(int TicketId, int NumSeats, DateTime Created, DateTime Updated)
    {
        public int Id { get; set; } = TicketId;

        public int NumSeats { get; set; } = NumSeats;

        public string CreatedAt { get; set; } = Created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = Updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }
}
