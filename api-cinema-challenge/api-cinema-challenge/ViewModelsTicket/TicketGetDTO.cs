using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsTicket
{
    public class TicketGetDTO
    {
        public string status { get; set; }
        public List<TicketData> data { get; set; } = new List<TicketData>();

        public TicketGetDTO(List<Ticket> tickets)
        {
            this.status = "success";
            foreach (var ticket in tickets)
            {
                this.data.Add(new TicketData(ticket));
            }
        }
    }
}
