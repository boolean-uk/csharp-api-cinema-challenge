namespace api_cinema_challenge.Models.DTOs
{
    public class TicketResponseListDTO
    {
        public string Status { get; set; }
        public ICollection<TicketDTO> Data { get; set; } = new List<TicketDTO>();
    }
}
