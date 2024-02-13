namespace workshop.wwwapi.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(object id);
        Task<T> Insert(T entity);
        Task<T> Delete(int id);
        Task<T> Update(object entityToUpdateID, T newEntity);
    }
}
