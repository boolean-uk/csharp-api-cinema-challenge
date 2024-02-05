using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Reposities.UserRepo
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
            var result = new User() { Name = name, Email = email, Phone = phonenumber, Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow };
            _db.Users.Add(result);
            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<User?> DeleteUser(int user_id)
        {
            var result = await GetUserById(user_id);
            if (result == null)
            {
                return null;
            }
            _db.Users.Remove(result);
            await _db.SaveChangesAsync();
            return result;

        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _db.Users.FindAsync(id);
        }

        public async Task<User?> UpdateUser(int user_id, string? name, string? email, string? phonenumber)
        {
            User? user = await GetUserById(user_id);
            if (user == null)
            {
                return null;
            }
            if (name == "")
            {
                return null;
            }
            if (email == "")
            {
                return null;
            }
            if (phonenumber == "")
            {
                return null;
            }

            if (name != null)
            {
                user.Name = name;
                user.Updated_at = DateTime.UtcNow;
            }
            if (email != null)
            {
                user.Email = email;
                user.Updated_at = DateTime.UtcNow;
            }
            if (phonenumber != null)
            {
                user.Phone = phonenumber;
                user.Updated_at = DateTime.UtcNow;
            }
            await _db.SaveChangesAsync();
            return user;

        }

        
    }
}
