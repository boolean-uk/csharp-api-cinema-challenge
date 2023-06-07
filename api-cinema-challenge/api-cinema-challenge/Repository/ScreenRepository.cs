using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class ScreenRepository : IScreenRepository
    {
        public bool AddScreen(Screen screen)
        {
            using (var db = new CinemaContext())
            {
                db.Screens.Add(screen);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteScreen(int id)
        {
            using (var db = new CinemaContext())
            {
                db.Remove(db.Screens.Find(id));
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Screen GetScreen(int id)
        {
            Screen result;
            using (var db = new CinemaContext())
            {
                result = db.Screens.Find(id);
                db.SaveChanges();
                return result;
            }
            return result;
        }

        public IEnumerable<Screen> GetScreens()
        {
            using (var db = new CinemaContext())
            {
                return db.Screens.ToList();
            }
            return null;
        }

        public bool UpdateScreen(Screen screen)
        {
            using (var db = new CinemaContext())
            {
                db.Update(screen);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
