namespace api_cinema_challenge.Models;

public class ReturnValue(string status, object data)
{
    public string Status { get; set; } = status;
    public object Data { get; set; } = data;
}