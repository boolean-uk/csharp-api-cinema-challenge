using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class ScreeningPOSTModel
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
