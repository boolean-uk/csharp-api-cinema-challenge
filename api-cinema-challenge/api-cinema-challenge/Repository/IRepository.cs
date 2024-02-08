using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Create(T entity);
        Task<IEnumerable<T>> ReadAll();
        Task<T> ReadById(int id);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
