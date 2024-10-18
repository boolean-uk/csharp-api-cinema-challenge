namespace api_cinema_challenge.Repository
{

    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> getAll();

        Task<IEnumerable<T>> getAllWithIncludes();

        Task<T> getByIdWithIncludes(int id);


        Task<T> getbyId(int id);

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);

        Task<IEnumerable<T>> GetByForeignKey(string foreignKeyName, object foreignKeyValue);





    }

}




