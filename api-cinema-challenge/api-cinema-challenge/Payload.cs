namespace api_cinema_challenge
{
    public class Payload<T> where T : class
    {
        public System.Net.HttpStatusCode status { get; set; }
        public T data { get; set; }
    }
}
