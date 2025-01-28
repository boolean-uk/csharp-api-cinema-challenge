using api_cinema_challenge.Models.Interfaces;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.DTO.Interfaces
{
    public interface IDTO_Request_update<T,Y> 
        where T : IDTO_Request_update<T, Y>
        where Y : BaseCustomModel,new()
    {
        public abstract static Task<Y?> update(T dto, IRepository<Y> repo, params object[] id);
    }
}
