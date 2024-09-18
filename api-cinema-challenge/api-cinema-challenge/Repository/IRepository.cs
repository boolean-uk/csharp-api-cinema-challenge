using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomer<T> 
    {
        Task<T> CreateEntity(T entity);
        Task<T> DeleteEntity(int id);
        Task<List<T>> GetAllEntities();
        Task<T> UpdateEntity(T entity, int searchId);
    }
    
    public interface IMovie<T>
    {
        Task<T> CreateEntity(T entity);
        Task<Screening> CreateEntityScreening(Screening screening);
        Task<T> DeleteEntity(int id);
        Task<List<T>> GetAllEntities();
        Task<T> GetAnEntityById(int id);
        Task<bool> CheckIfEntityHasAScreening(int movieId, DateTime startsAt);
        Task<List<Screening>> GetAllEntityScreenings(int movieId);
        Task<Movie> UpdateEntity(UpdateMovieDTO entity, int searchId);
    }
    public interface IScreening<T>
    {
        Task<T> CreateEntity(T entity);
        Task<List<T>> GetAllEntities(int movieId);
    }
    public interface ITickets<T>
    {
        Task<T> CreateEntity(T entity);
        Task<List<T>> GetAllEntities(int customerId, int screeningId);
    }
}
