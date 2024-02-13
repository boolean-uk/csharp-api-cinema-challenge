using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class UserRepository : IUserRepository
    {
        private CinemaContext _db;

        public UserRepository(CinemaContext db)
        {
            _db = db;
        }

        public ApplicationUser? GetUser(string email)
        {
            return _db.ApplicationUsers.FirstOrDefault(u => u.Email == email);
        }


        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
