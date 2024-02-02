using api_cinema_challenge.Models;
using System.Collections.Generic;

namespace api_cinema_challenge.Controllers.UserRepo
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> GetAllUsers();
        Task<User?> GetUserById(int id);
        Task<User?> CreateUser(string name, string email, string phonenumber);
        Task<User?> UpdateUser(int user_id, string? name, string? email, string? phonenumber);
        Task<User?> DeleteUser(int user_id);

    
    }
}
