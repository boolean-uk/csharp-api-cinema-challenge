using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO.CustomerDTOs;
using api_cinema_challenge.Models.DTO.TicketDTOs;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Task<GetCustomerDTO> CreateCustomer(CreateCustomerDTO cDTO);
        Task<List<GetCustomerDTO>> GetCustomers();
        Task<GetCustomerDTO?> UpdateCustomer(int customerId, CreateCustomerDTO uDTO);
        Task<GetCustomerDTO?> DeleteCustomer(int customerId);
        Task<GetTicketDTO?> CreateTicket(int customerId, int screeningId, CreateTicketDTO cDTO);
        Task<List<GetTicketDTO>> GetTickets(int customerId, int screeningId);
    }
    public class CustomerRepository(CinemaContext db) : ICustomerRepository
    {
        private CinemaContext _db = db;
        public async Task<GetCustomerDTO> CreateCustomer(CreateCustomerDTO cDTO)
        {
            Customer customer = new()
            {
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Email = cDTO.Email,
                Name = cDTO.Name,
                Phone = cDTO.Phone,
            };
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return new GetCustomerDTO()
            {
                Id = customer.Id,
                Email = customer.Email,
                Name = customer.Name,
                Phone = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt,
            };
        }

        public async Task<List<GetCustomerDTO>> GetCustomers()
        {
            return await _db.Customers.Select(x => new GetCustomerDTO()
            {
                Id = x.Id,
                Email = x.Email,
                Name = x.Name,
                Phone = x.Phone,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            }).ToListAsync();
        }

        public async Task<GetCustomerDTO?> UpdateCustomer(int customerId, CreateCustomerDTO uDTO)
        {
            Customer? dbCustomer = await _db.Customers.Where(x => x.Id == customerId).FirstOrDefaultAsync();
            if (dbCustomer == null) { return null; }
            dbCustomer.Name = uDTO.Name;
            dbCustomer.Phone = uDTO.Phone;
            dbCustomer.Email = uDTO.Email;
            dbCustomer.UpdatedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();
            return new GetCustomerDTO()
            {
                Id = dbCustomer.Id,
                Email = dbCustomer.Email,
                Name = dbCustomer.Name,
                Phone = dbCustomer.Phone,
                CreatedAt = dbCustomer.CreatedAt,
                UpdatedAt = dbCustomer.UpdatedAt,
            };
        }

        public async Task<GetCustomerDTO?> DeleteCustomer(int customerId)
        {
            Customer? dbCustomer = await _db.Customers.Where(x => x.Id == customerId).FirstOrDefaultAsync();
            if (dbCustomer == null) { return null; }
            _db.Customers.Remove(dbCustomer);
            await _db.SaveChangesAsync();
            return new GetCustomerDTO()
            {
                Id = dbCustomer.Id,
                Email = dbCustomer.Email,
                Name = dbCustomer.Name,
                Phone = dbCustomer.Phone,
                CreatedAt = dbCustomer.CreatedAt,
                UpdatedAt = dbCustomer.UpdatedAt,
            };
        }


        public async Task<GetTicketDTO?> CreateTicket(int customerId, int screeningId, CreateTicketDTO cDTO)
        {
            Customer? dbCustomer = await _db.Customers.Where(x => x.Id == customerId).FirstOrDefaultAsync();
            if (dbCustomer == null) { return null; }
            Screening? dbScreening = await _db.Screenings.Where(x => x.Id == screeningId).FirstOrDefaultAsync();
            if (dbScreening == null) { return null; }
            Ticket ticket = new()
            {
                ScreeningId = screeningId,
                CustomerId = customerId,
                SeatNumber = cDTO.NumSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();
            return new GetTicketDTO()
            {
                Id = ticket.Id,
                NumSeats = ticket.SeatNumber,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt,
            };
        }

        public async Task<List<GetTicketDTO>> GetTickets(int customerId, int screeningId)
        {
            return await _db.Tickets.Where(x => x.CustomerId == customerId && x.ScreeningId == screeningId).Select(x => new GetTicketDTO()
            {
                Id = x.Id,
                NumSeats = x.SeatNumber,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            }).ToListAsync();
        }
    }
}
