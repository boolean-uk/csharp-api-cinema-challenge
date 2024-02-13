namespace api_cinema_challenge.Models
{
    public class ApiResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }
}
