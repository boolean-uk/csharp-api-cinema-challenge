namespace api_cinema_challenge.Models.PayLoad
{
    public class PayLoad1<T> where T : class
    {
        public string status { get; set; } = "success";
        public T data { get; set; }
    }
}
