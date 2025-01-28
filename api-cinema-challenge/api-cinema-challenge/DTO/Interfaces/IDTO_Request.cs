using api_cinema_challenge.Models.Interfaces;

namespace api_cinema_challenge.DTO.Interfaces
{
    public interface IDTO_Request<T,Y> 
        where T : IDTO_Request<T, Y>
        where Y : BaseCustomModel,new()
    {
        public abstract static Y create(T dto);
    }
}
