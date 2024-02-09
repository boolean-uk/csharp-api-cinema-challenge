namespace api_cinema_challenge.Repository
{
    public interface IDualKeyRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetByID(object id1, object id2);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T?> DeleteByID(object id1, object id2);
    }
}
