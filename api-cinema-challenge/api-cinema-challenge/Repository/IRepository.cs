using api_cinema_challenge.Models;
using api_cinema_challenge.DTO;
using System.Numerics;

namespace api_cinema_challenge.Repository
{

    public enum PreloadPolicy
    {
        DoNotPreloadRelations,
        PreloadRelations
    }
    public interface IRepository
    {



        //******************* Customer ***********************

        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer?> GetCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> CreateCustomer(string name, string email, string phone);
        Task<Customer?> DeleteCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> UpdateCustomer(int customerId, string name, string email, string phone,
            PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);



        //******************* Movie **************************
        Task<Movie> CreateMovie(string title, string rating , string description, int runtime);
        Task<Movie> GetAllMovies(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> UpdateMovie(int id, string title, string rating, string description, int runetime,PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Movie> DeleteMovie(int id, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);


        //******************* Screening *****************************
        Task<Screening> CreateScreening(int screenNumber, int capacity, DateTime datetime, int movieId);
        Task<IEnumerable<Screening>> GetAllScreenings();

        void SaveChanges();

    }
}
