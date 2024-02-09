using api_cinema_challenge.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> GetByCompositeId(int screeningId, int customerId);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}