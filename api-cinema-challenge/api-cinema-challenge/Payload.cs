namespace api_cinema_challenge
{
    public class Payload<T> where T : class
    {
        public T Data { get; set; }
    }
}
