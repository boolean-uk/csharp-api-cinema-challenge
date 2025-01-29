using System.Transactions;

namespace api_cinema_challenge.Response
{
    public class ErrorResponse : Response<Error>
    {
        public ErrorResponse(Error data) : base("Error", data)
        {
        }
    }
}
