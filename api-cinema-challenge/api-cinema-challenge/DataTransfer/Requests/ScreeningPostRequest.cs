using api_cinema_challenge.Models;
using Npgsql.PostgresTypes;

namespace api_cinema_challenge.DataTransfer.Requests
{
    public class ScreenPostRequest
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
