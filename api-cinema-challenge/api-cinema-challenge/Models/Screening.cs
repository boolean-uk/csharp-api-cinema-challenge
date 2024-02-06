using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        //FK props to Movie
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        // Method to calculate available seats for Ticketsale
        public int AvailableSeats
        {
            get
            {
                // Calculate the number of tickets sold for this screening
                int soldTicketsCount = 0;
                // Calculate available seats by subtracting sold tickets from capacity
                int availableSeats = Capacity - soldTicketsCount;
                // Ensure available seats are not negative
                return Math.Max(0, availableSeats);
            }
        }
    }
}
