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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Screening()
        {

        }

        public Screening(int id, int screenNumber, int capacity, DateTime startsAt)
        {
            Id = id;
            ScreenNumber = screenNumber;
            Capacity = capacity;
            StartsAt = startsAt;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = CreatedAt;
        }
    }
}
