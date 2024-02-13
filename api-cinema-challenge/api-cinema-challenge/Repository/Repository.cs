using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        /// SCREENINGS
        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await _db.Screenings.Where(x => x.MovieId == id).Include(a => a.Movie).ToListAsync();
        }


        public async Task<Screening?> CreateScreening(int screennumber, int capacity, DateTime datetime, int movieId)
        {
            if (screennumber <= 0 || capacity <= 0 ) return null;
            var screening = new Screening { 
                ScreenNumber = screennumber,
                Capacity = capacity,
                MovieId = movieId,
                StartsAt = datetime,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime()
                 };
            await _db.Screenings.AddAsync(screening);
            return screening;
        }


        /// TICKETS 
        //Get a list of every ticket a customer has booked for a screening.
        public async Task<IEnumerable<Ticket>> GetTickets(int custId, int screenId)
        {
            return await _db.Tickets.Where(x => x.ScreeningId == screenId).Where(x => x.CustomerId == custId).ToListAsync();
        }



        public async Task<Ticket?> CreateTicket(int custId, int screenId, int numSeats)
        {
            if (custId <= 0 || screenId <= 0) return null;

            var cust = _db.Customers.FirstOrDefault(x => x.Id == custId);
            var screen = _db.Screenings.FirstOrDefault(x => x.Id == screenId);

            int maxId = _db.Tickets.Count();

            if (cust == null || screen == null) return null;


            var ticket = new Ticket
            {
                Id = maxId + 1,
                NumSeats = numSeats,
                CustomerId = custId,
                Customer = cust,
                ScreeningId = screenId,
                Screening = screen,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime()
            };
            await _db.Tickets.AddAsync(ticket);
            return ticket;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
