using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.CustomerDTOs
{
    public class TicketNoCustomer
    {
        public ScreeningNoTicket Screening { get; set; } 
        public TicketNoCustomer(Ticket ticket)
        {
            Screening = new ScreeningNoTicket(ticket.Screening);
        }
    }
}
