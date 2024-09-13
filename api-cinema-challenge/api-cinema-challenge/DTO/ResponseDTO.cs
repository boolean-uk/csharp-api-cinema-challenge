namespace api_cinema_challenge.DTO
{
    public class ResponseDTO<T> where T : class
    {
        public string status {  get; set; }
        public T Data { get; set; }

        public ResponseDTO(string status, T data)
        {
            this.status = status;
            Data = data;
        }
    }
}
