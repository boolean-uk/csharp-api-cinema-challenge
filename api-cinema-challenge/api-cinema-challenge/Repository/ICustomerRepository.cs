using api_cinema_challenge.DTOs;

namespace api_cinema_challenge.Repository;

public interface ICustomerRepository
{
    public Task<IEnumerable<CustomerGetDto>> GetCustomers();
    public Task<CustomerGetDto> PostCustomer(CustomerPostDto cpd);
    public Task<CustomerGetDto> UpdateCustomer(int id, CustomerUpdateDto cud);
    public Task<CustomerGetDto> DeleteCustomer(int id);
    public Task<TicketGetDto> BookTicket(int customerId, int screeningId, NumSeatsDto numSeats);
    public Task<IEnumerable<TicketGetDto>> GetTickets(int customerId, int screeningId);
}