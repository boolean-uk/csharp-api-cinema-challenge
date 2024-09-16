namespace api_cinema_challenge.DTO
{
    public class Payload<T> where T : class
    {
        public T? Data { get; set; }
    }
}
