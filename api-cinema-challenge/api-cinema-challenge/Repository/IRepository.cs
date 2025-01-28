using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{

    public interface IRepository<T> where T : class 
    {
        Task<IEnumerable<T>> GetEntries(params Func<IQueryable<T>, IQueryable<T>>[] includes);
        Task<T?> GetEntry(Func<IQueryable<T>, IQueryable<T>> id, params Func<IQueryable<T>, IQueryable<T>>[] expressions);
        Task<T?> CreateEntry(T entry);
        Task<T?> UpdateEntry(Func<IQueryable<T>, IQueryable<T>> id, T entry);
        Task<T?> DeleteEntry(Func<IQueryable<T>, IQueryable<T>> id);
    }
    
}
