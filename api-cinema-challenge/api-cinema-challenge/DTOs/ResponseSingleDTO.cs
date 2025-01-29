namespace api_cinema_challenge.DTOs
{
    public class ResponseSingleDTO<T> where T : class
    {
        public string Status { get; set; } = "Success";

        public T Data { get; set; }
    }
}
