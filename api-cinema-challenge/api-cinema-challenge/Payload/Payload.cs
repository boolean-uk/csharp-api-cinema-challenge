namespace api_cinema_challenge.Payload
{
    public class ApiResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }
}