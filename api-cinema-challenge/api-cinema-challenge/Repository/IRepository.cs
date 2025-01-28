using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{

    public interface IRepository<T> where T : class 
    {
        Task<IEnumerable<T>> GetEntries(params Func<IQueryable<T>, IQueryable<T>>[] includes);
        Task<T?> GetEntry(Func<IQueryable<T>, IQueryable<T>> id, params Func<IQueryable<T>, IQueryable<T>>[] expressions);
        Task<T?> CreateEntry(T entry);
    }
    
}
