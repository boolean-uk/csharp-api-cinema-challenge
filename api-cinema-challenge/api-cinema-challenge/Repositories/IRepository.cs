using api_cinema_challenge.Models;
using api_cinema_challenge.VIewModelsCustomer;
using api_cinema_challenge.ViewModelsMovie;
using api_cinema_challenge.ViewModelsScreening;
using api_cinema_challenge.ViewModelsTicket;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        public Task<CustomerDTO> AddCustomer(Customer entity);
        public Task<CustomerGetDTO> GetCustomers();
        public Task<CustomerDTO> UpdateCustomer(int id, Customer entity);
        public Task<CustomerDTO> RemoveCustomer(int id);
        public Task<MovieDTO> AddMovie(Movie entity);
        public Task<MovieGetDTO> GetMovies();
        public Task<MovieDTO> UpdateMovie(int id, Movie entity);
        public Task<MovieDTO> RemoveMovie(int id);
        public Task<ScreeningDTO> AddScreening(Screening entity);
        public Task<ScreeningGetDTO> GetScreenings(int id);
        public Task<TicketDTO> AddTicket(Ticket entity);
        public Task<TicketGetDTO> GetTickets(int customerId, int screeningId);

    }
}
