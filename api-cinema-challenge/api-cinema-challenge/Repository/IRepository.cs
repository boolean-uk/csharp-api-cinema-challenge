using api_cinema_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Insert(T entity);
        Task<IEnumerable<T>> SelectAll();
        Task<T> SelectById(int id);
        Task<T> Update(int id, T entity);
        Task<T> Delete(int id);
        Task<IEnumerable<T>> SelectWhere(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> InsertRange(IEnumerable<T> entities);
    }
}
