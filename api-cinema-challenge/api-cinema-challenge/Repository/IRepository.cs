using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public CustomerDTO CreateCustomer(string name, string email, string phone);
        public List<CustomerDTO> GetCustomers();
        public CustomerDTO UpdateCustomer(int id, string name, string email, string phone);
        public CustomerDTO DeleteCustomer(int id);

        public Payload<MovieDTO> CreateMovie();
        public Payload<List<MovieDTO>> GetMovies();
        public Payload<MovieDTO> UpdateMovies();
        public Payload<MovieDTO> DeleteMovie();

        public Payload<ScreeningDTO> CreateScreening();
        public Payload<ScreeningDTO> GetScreenings();

        public Payload<TicketDTO> BookTicket();
        public Payload<List<TicketDTO>> GetTickets();

    }
}
