using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomer<Customer>
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateEntity(Customer entity)
        {
            if ((entity.Name == null) || (entity.Email == null) || (entity.Phone == null))
                throw new ArgumentNullException();

            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> DeleteEntity(int id)
        {
            var entity = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);


            if (entity == null)
                throw new KeyNotFoundException("The database does not have element with provided Id");

            _db.Customers.Remove(entity);
            _db.SaveChangesAsync();

            return entity;
        }

        public async Task<List<Customer>> GetAllEntities()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateEntity(Customer entity, int searchId)
        {
            var target = await _db.Customers
                .FirstOrDefaultAsync(x => x.Id == searchId);

            target.Name = entity.Name;
            target.Email = entity.Email;
            target.Phone = entity.Phone;
            target.updatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return target;
        }
    }
}
