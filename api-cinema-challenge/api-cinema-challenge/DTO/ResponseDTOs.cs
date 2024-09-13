namespace api_cinema_challenge.DTO
{
    public class ResponseDTOs<T> where T : class
    {
        public string status { get; set; }
        public List<T> Data { get; set; }

        public ResponseDTOs(string status, List<T> data)
        {
            this.status = status;
            Data = data;
        }
    }
}
