using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DTOs.Ticket
{
    public class TicketResponseDTO
    {
        public string Status { get; set; } = "success";
        public TicketDTO? Data { get; set; }
    }
}
