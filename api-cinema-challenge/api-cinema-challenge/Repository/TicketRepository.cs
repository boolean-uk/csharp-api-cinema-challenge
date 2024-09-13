using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketRepository(CinemaContext db) : IRepository<Ticket>
    {
        public async Task<Ticket> Add(Ticket entity)
        {
            await db.AddAsync(entity);  
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<Ticket>> GetAllById(int id)
        {
            return await db.Tickets.Where(t => t.CustomerId == id).ToListAsync();
        }

            
        public Task<Ticket> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ticket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> GetById(int id)
        {
            throw new NotImplementedException();
        }



        public async Task<Ticket> Update(Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}
