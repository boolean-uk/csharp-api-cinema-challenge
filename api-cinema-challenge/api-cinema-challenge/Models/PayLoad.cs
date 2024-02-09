namespace api_cinema_challenge.Models
{
    public class PayLoad<T> where T : class
    {
        public string status { get; set; } = "success";
        public T data { get; set; }

        public PayLoad(T data)
        {
            this.data = data;
        }

    }
}
