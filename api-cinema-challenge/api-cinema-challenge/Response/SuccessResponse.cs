using System.Transactions;

namespace api_cinema_challenge.Response
{
    public class SuccessResponse : Response<Error>
    {
        public SuccessResponse(Error data) : base("Success", data)
        {
        }
    }
}
