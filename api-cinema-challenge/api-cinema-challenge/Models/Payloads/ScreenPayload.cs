using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screens")]
    public class ScreenPayload
    {
        public int Capacity { get; set; }

        public string CheckPayload()
        {
            if (Capacity <= 0) { return "Can't have less than 0 capacity"; }
            return string.Empty;
        }
    }
}
