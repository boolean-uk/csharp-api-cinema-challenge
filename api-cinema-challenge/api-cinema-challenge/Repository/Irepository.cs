using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Threading.Tasks;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        //User
        Task<User> CreateUser(string name, string email, string PhoneNumber); //create
        Task<IEnumerable<User>> GetUsers(); //get
        Task<User> UpdateUser(int id, string name, string email, string phoneNumber); //update
        Task<User> DeleteUser(int id); //delete

        //Movie 
        Task<Movie> CreateMovie(string title, string rating, string desc, int runtime); //create
        Task<IEnumerable<Movie>> GetMovies(); //get
        Task<Movie> UpdateMovie(int id, string title, string rating, string description, int runtime); //update
        Task<Movie> DeleteMovie(int id); //delete

        //Screening
        Task<Screening> CreateScreening(int movieId, int screenNumber, int capacity, DateTime startsAt); //create
        Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId); //get
    }
}