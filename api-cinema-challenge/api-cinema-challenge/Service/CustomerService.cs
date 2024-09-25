using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Npgsql.PostgresTypes;

namespace api_cinema_challenge.Controller
{
    public class CustomerService
    {
        public IRepository<Customer> repository;
        public CustomerService(CinemaContext db, IRepository<Customer> repository)
        {
            this.repository = repository;
        }
        public Task<IEnumerable<Customer>> GetAll()
        {
            return repository.GetAll();
        }

        public Task<Customer> Create(CustomerPayload payload)
        {
            Customer customer = new Customer() { 
                Name = payload.Name,
                Email = payload.Email,
                Phone = payload.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            return repository.Create(customer);
        }
        public Task<Customer> Update(int id, CustomerPayload newCustomer)
        {
            Customer customer = new Customer()
            {
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone,
                UpdatedAt = DateTime.UtcNow,
            };

            return repository.Update(id, customer);
        }
        public Task<Customer> Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
