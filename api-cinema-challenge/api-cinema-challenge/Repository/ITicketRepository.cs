using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ITicketRepository
    {
        public Task<Ticket> CreateTicket(int numSeats, Customer customer, Screening screening);
        public Task<ICollection<Ticket>> GetTickets(int customerID, int screeningID);
        public Task<ICollection<Ticket>> GetTicketsbyCustomer(Customer customer);
        public Task<ICollection<Ticket>> GetTicketsbyScreening(Screening screening);
    }
}
