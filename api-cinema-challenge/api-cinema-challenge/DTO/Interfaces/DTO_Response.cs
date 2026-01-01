using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api_cinema_challenge.DTO.Interfaces
{
    public interface IDTO_Respons<Y> {
        public void Initialize(Y model);
    }
    public abstract class DTO_Response<T, Y> : IDTO_Respons<Y>
        where T : DTO_Response<T, Y>, new()
        where Y : BaseCustomModel
    {
        public DTO_Response() { }
        public abstract void Initialize(Y model);
        public static Payload<T,Y> toPayload(Y model, string status = "success")
        {
            var a = new T();
            a.Initialize(model);

            var p = new Payload<T,Y>();
            p.Data = a;
            p.Status = status;
            return p;
        }
        public static Payload<IEnumerable<T>, Y> toPayload(IEnumerable<Y> models, string status = "success")
        {
            var list = models.Select(x => { var a = new T(); a.Initialize(x); return a; }).ToList();

            var p = new Payload<IEnumerable<T>,Y>();
            p.Data = list;
            p.Status = status;
            return p;
        }
    }
}
