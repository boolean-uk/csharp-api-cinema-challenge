
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public  DateTime Created { get; set; }
        public DateTime Updated { get; set; }


    }
}
