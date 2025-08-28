namespace api_cinema_challenge.DTO
{
    public class ApiResponse<T>
    {
        public string Status { get; set; } = "success";
        public T Data { get; set; }
        //public string? ErrorMessage { get; set; } 


        public ApiResponse(T data)
        {
            Data = data;
        }

        public ApiResponse()
        {
            Status = "failed";
            //ErrorMessage = error;
        }
    }
}
