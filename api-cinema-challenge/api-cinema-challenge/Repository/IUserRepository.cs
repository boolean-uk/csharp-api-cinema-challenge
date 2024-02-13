using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IUserRepository
    {
        public ApplicationUser? GetUser(string email);
    }
}
