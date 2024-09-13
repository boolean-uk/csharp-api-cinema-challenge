using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Payloads
{
    public class ScreeningPayload
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        
        
        [RegularExpression(@"^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}", ErrorMessage = "Invalid Format. Expected Format: YYYY-MM-DD HH:MM:SS")]
        public string StartsAt { get; set; }

        public ScreeningPayload(int screenNumber, int capacity, string startsAt)
        {
            ScreenNumber = screenNumber;
            Capacity = capacity;
            StartsAt = startsAt;
        }
    }
}
