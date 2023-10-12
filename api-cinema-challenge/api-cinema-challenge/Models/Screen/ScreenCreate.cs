using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Screen
{
    [NotMapped]
    public class ScreenCreate
    {
        public string status { get; set; } = "success";
        public Screen data { get; set; }
    }
}
