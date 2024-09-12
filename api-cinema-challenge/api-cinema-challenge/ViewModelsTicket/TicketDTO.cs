using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsTicket
{
    public class TicketDTO
    {
        public string status {  get; set; }
        public TicketData data { get; set; }

        public TicketDTO(Ticket ticket) 
        {
            this.status = "success";
            this.data = new TicketData(ticket);
        }
    }
}
