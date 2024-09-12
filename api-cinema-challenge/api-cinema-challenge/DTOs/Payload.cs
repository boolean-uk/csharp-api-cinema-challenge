namespace api_cinema_challenge.DTOs
{
    public class Payload<T> where T : class
    {
        public string Status { get; set; } = "success";
        public T Data {  get; set; } 
    }
}
