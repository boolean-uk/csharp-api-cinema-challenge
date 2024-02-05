using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketResponseDTO
    {
        public string Status { get; set; }
        public TicketDataDTO Datas { get; set; }

        public TicketResponseDTO(Ticket ticket)
        {
            Status = "Success";
            Datas = new TicketDataDTO(ticket);
        }

        public static List<TicketResponseDTO> FromRepository(IEnumerable<Ticket> tickets)
        {
            var results = new List<TicketResponseDTO>();
            foreach (var ticket in tickets)
                results.Add(new TicketResponseDTO(ticket));
            return results;
        }

        public static TicketResponseDTO FromARepository(Ticket ticket)
        {
            TicketResponseDTO result = new TicketResponseDTO(ticket);
            return result;
        }
    }
}
