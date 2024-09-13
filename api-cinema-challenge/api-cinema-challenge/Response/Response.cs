namespace api_cinema_challenge.Payload
{
    public class Response<T> where T : class
    {
        public string Status { get; set; } = "success";
        public T Data { get; set; }

    }
}
