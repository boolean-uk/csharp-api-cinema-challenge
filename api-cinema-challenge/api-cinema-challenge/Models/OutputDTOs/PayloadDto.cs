using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Models.OutputDTOs
{

    public class Payload<T> where T : class
    {
        public string Status { get; set; } = "success";
        public T Data { get; set; }

        public Payload<T> Get(T data)
        {
            Data = data;
            return this;
        }
    }

}
