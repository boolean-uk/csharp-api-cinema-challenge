namespace api_cinema_challenge.Repository
{
    public interface IRepository<T, TKey> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Create(TKey entity);

        Task<T> Update(TKey entity, int id);

        Task<T> Delete(int id);
    }
}
