namespace api_cinema_challenge.Models.DTOs.Ticket
{
    public class TicketResponseListDTO
    {
        public string Status { get; set; } = "success";
        public ICollection<TicketDTO>? Data { get; set; }
    }
}
