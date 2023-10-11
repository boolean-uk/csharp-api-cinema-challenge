using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepo : IScreeningRepo
    {
        public bool AddScreening(Screening screening)
        {
            using(var db = new CinemaContext())
            {
                if (screening != null) 
                { 
                    db.Screenings.Add(screening);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public IEnumerable<Screening> GetAllScreenings()
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.ToList();
            }
            return null;
        }
    }
}
