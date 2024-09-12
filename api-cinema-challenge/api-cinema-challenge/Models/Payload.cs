namespace api_cinema_challenge.Models
{
    public class Payload<T> where T : class
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }
}
