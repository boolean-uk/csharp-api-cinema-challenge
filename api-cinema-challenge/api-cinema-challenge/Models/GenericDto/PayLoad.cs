namespace api_cinema_challenge.Models.GenericDto
{
    public class PayLoad<T> where T : class
    {
        public string status { get; set; } = "success";
        public T data { get; set; }
    }
}
