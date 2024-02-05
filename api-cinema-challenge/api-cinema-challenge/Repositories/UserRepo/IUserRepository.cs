using api_cinema_challenge.Models;
using System.Collections.Generic;

namespace api_cinema_challenge.Reposities.UserRepo
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> getAllUsers();
        Task<User?> getUserById(int id);
        Task<User?> createUser(string name, string email, string phonenumber);
        Task<User?> updateUser(int user_id, string? name, string? email, string? phonenumber);
        Task<User?> deleteUser(int user_id);

    
    }
}
