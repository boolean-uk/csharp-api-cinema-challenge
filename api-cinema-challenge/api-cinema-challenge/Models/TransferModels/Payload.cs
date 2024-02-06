namespace api_cinema_challenge.Models.TransferModels
{
    public class Payload<T>(T Data) where T : class
    {
        public string status { get; set; } = "success";

        public T data { get; set; } = Data;
    }
}
