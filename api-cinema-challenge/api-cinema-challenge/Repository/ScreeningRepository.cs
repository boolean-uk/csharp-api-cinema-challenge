using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        public bool AddScreening(Screening screening)
        {
            using (var db = new CinemaContext())
            {
                db.Screenings.Add(screening);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Screening> GetScreenings()
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.Include(e => e.Movie).Include(e => e.Screen).ToList();
            }
            return null;
        }
    }
}
