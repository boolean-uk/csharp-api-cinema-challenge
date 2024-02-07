namespace api_cinema_challenge.Models
{

    public class Payload<T1> where T1 : class
    {
        public string status { get; set; } = "success";
        public T1 data { get; set; }

    }
}
    
    
