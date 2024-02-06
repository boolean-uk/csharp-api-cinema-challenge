using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Models.JunctionModels
{
    public class CustomerTicket
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }
    }
}
