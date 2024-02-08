namespace api_cinema_challenge.Repository;

public interface IRepository<T>
{
    Task<T> Create(T entity);
    Task<T?> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<T?> Update(T entity);
    Task<T?> Delete(int id);
}
