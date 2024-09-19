namespace api_cinema_challenge.Payload
{
    public class Payload<T> where T : class
    {
        public string status {  get; set; }
        public T data {  get; set; }
    }
}
