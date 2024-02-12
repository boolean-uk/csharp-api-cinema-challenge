namespace api_cinema_challenge.Repository
{
    public interface IDualKeyRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(object id1, object id2);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T?> DeleteById(object id1, object id2);
    }
}
