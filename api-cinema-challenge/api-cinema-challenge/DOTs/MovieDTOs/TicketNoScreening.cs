using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.MovieDTOs
{
    public class TicketNoScreening
    {
        public CustomerNoTicket Customer { get; set; }
        public TicketNoScreening(Ticket ticket)
        {
            Customer = new CustomerNoTicket(ticket.Customer);
        }
    }
}
