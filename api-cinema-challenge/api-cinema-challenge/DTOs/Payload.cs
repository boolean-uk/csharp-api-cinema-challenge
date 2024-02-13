namespace api_cinema_challenge.DTOs
{
    public class Payload<T> where T : class
    {
        public string status { get { return "success"; } set { } }
        public T data { get; set; }
        


    }


}
