using api_cinema_challenge.DTOS;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        Task<CreateCustomerDTO> CreateCustomer(CreateCustomerDTO createCustomerDTO);
        Task<IEnumerable<CustomerDTO>> GetCustomers();
        Task<CreateCustomerDTO> UpdateCustomer(CreateCustomerDTO updateCustomerDTO, int id);
        Task<CustomerDTO> DeleteCustomer(int id);


        Task<CreateMovieDTO> CreateMovie(CreateMovieDTO createMovieDTO);
        Task<IEnumerable<MovieDTO>> GetMovies();
        Task<CreateMovieDTO> UpdateMovie(CreateMovieDTO updateMovieDTO, int id);
        Task<MovieDTO> DeleteMovie(int id);


        Task<CreateScreeningDTO> CreateScreening(CreateScreeningDTO createScreeningDTO);
        Task<IEnumerable<ScreeningDTO>> GetScreeningsById(int movieId);

         Task<TicketDTO> GetTicketById(int customerId, int screeningId);

        Task<TicketDTO> CreateTicket(CreateTicketDTO createTicketDTO);
    }
}
