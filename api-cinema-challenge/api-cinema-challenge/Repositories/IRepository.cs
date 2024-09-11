using api_cinema_challenge.Models;
using System.Collections.ObjectModel;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        // TODO: Refactor so that repositories are generalized
        // ----------- CUSTOMER ----------- 
        Task<ICollection<Customer>> GetAllCustomers();
        Task<Customer> GetACustomer(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);

        // ----------- MOVIE ----------- 
        Task<ICollection<Movie>> GetAllMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie);
        Task<Movie> DeleteMovie(int id);

        // ----------- SCREENING ----------- 
        Task<ICollection<Screening>> GetAllScreenings();
        Task<Screening> GetScreening(int id);
        Task<Screening> CreateScreening(Screening screening);
        Task<Screening> UpdateScreening(Screening screening);

        // ----------- TICKET ----------- 
        Task<ICollection<Ticket>> GetAllTickets();
        Task<Ticket> GetTicket(int id);
        Task<Ticket> UpdateTicket(Ticket ticket);

    }
}
