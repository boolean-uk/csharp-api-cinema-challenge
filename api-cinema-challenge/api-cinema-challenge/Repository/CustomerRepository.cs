using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository {

    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db) {
            _db = db;
        }
        public async Task<Customer> CreateCustomer(string name, string email, string phone)
        {
            Customer customer = new Customer() 
            {
                Name = name,
                Email = email,
                Phone = phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers
                .Include(tickets => tickets.Tickets)
                .ThenInclude(ticket => ticket.Screening)
                .ThenInclude(movie => movie.Movie)
                .Include(tickets => tickets.Tickets)
                .ThenInclude(tickets => tickets.Seats)
                .ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int Id)
        {
            if (Id <= 0)
            {
                return null;
            }

            var customer = await _db.Customers
                .Include(c => c.Tickets)
                .ThenInclude(t => t.Screening)
                .ThenInclude(s => s.Movie)
                .Where(c => c.Id == Id)
                .FirstOrDefaultAsync();

            if (customer == null)
            {
                return null;
            }

            Console.WriteLine(customer.Name);
            foreach (Ticket item in customer.Tickets)
            {
                Console.WriteLine(item.ScreeningId);
                foreach (Seat seat in item.Seats)
                {
                    Console.WriteLine(seat.SeatRow + seat.SeatNumber);
                }
            }

            return customer;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer, Customer Newcustomer)
        {
            customer = Newcustomer;
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return customer;
        }
    }
}