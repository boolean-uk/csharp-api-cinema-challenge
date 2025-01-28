namespace api_cinema_challenge.DTO;

public class BaseResponse<T>
{
    public string Status { get; set; }
    public T Data { get; set; }
    
    public BaseResponse(string status, T data)
    {
        Status = status;
        Data = data;
    }
}