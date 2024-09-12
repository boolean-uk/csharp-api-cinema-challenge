using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        //done
        public CustomerDTO CreateCustomer(string name, string email, string phone);
        public List<CustomerDTO> GetCustomers();
        public CustomerDTO UpdateCustomer(int id, string name, string email, string phone);
        public CustomerDTO DeleteCustomer(int id);

        //underway
        public MovieDTO CreateMovie(string title, string rating, string description, int runtime);
        public List<MovieDTO> GetMovies();
        public MovieDTO UpdateMovie(int id, string title, string rating, string description, int runtime);
        public MovieDTO DeleteMovie(int id);

        public ScreeningDTO CreateScreening(int screenNumber, int capacity, DateTime startsAt);
        public List<ScreeningDTO> GetScreenings();

        public TicketDTO BookTicket(int id);
        public List<TicketDTO> GetTickets();

    }
}
