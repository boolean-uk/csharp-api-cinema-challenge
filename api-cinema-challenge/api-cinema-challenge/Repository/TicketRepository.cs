using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public Payload<TicketDTO> BookTicket() { throw new NotImplementedException(); }
        public Payload<List<TicketDTO>> GetTickets() { throw new NotImplementedException(); }
    }
}
