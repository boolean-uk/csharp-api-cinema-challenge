namespace api_cinema_challenge
{
    public class CustomAPIResponse<T>
    {
        public CustomAPIResponse(string status, T data)
        {
            this.status = status;
            this.data = data;
        }

        public string status { get; set; }

        public T data { get; set; }


    }
}
