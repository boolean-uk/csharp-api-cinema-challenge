using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Controllers
{
    public class UserRepository : IUserRepository
    {

        private CinemaContext _db;

        public UserRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<User?> CreateUser(string name, string email, string phonenumber)
        {
            if (name == null || name == "")
            {
                return null;
            }
            if (email == null || email == "")
            {
                return null;
            }
            if (phonenumber == null || phonenumber == "")
            {
                return null;
            }
            var result = new User() { UserId = 0, Name = name, Email = email, Phone = phonenumber, Created_at = DateTime.Now, Updated_at = DateTime.Now };
            _db.Users.Add(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public Task<User?> DeleteUser(int user_id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _db.Users.ToListAsync();
        }

        public Task<User?> UpdateUser(int user_id, string? name, string? email, string? phonenumber)
        {
            throw new NotImplementedException();
        }
    }
}
