using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge
{
    [NotMapped]
    public class Payload<T> where T : class
    {
        public string status { get; set; } = "success";
        public T data { get; set; }
    }
}
