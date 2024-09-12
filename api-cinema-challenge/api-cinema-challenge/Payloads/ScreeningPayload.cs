using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Payloads
{
    public class ScreeningPayload
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }

        public ScreeningPayload(int screenNumber, int capacity, DateTime startsAt)
        {
            ScreenNumber = screenNumber;
            Capacity = capacity;
            StartsAt = startsAt;
        }
    }
}
