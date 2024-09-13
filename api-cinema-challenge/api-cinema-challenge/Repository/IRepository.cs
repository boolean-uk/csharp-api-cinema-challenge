using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<ResponseDTOs<CustomerDTO>> GetCustomers();
        Task<ResponseDTOs<MovieDTO>> GetMovies();
        Task<ResponseDTOs<ScreeningDTO>> GetScreenings(int movieId);
        Task<ResponseDTO<CustomerDTO>> CreateCustomer(CustomerPayload payload);
        Task<ResponseDTO<MovieDTO>> CreateMovie(MoviePayload payload);
        Task<ResponseDTO<ScreeningDTO>> CreateScreening(int movieId, ScreeningPayload payload);
        Task<ResponseDTO<CustomerDTO>> UpdateCustomer(int customerId, CustomerPayload payload);
        Task<ResponseDTO<MovieDTO>> UpdateMovie(int movieId, MoviePayload payload);
        Task<ResponseDTO<CustomerDTO>> DeleteCustomer(int customerId);
        Task<ResponseDTO<MovieDTO>> DeleteMovie(int movieId);
        Task<ResponseDTO<TicketDTO>> BookTicket(int numSeats, int customerId, int screeningId);
        Task<ResponseDTOs<TicketDTO>> GetTickets(int customerId, int screeningId);

    }
}
