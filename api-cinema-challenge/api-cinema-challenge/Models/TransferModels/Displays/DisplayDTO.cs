using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Models.TransferModels.Displays
{
    public class DisplayDTO(int Id, int ScreenNumber, int Capacity, DateTime created, DateTime updated, ICollection<Screening> screenings)
    {
        public int DisplayId { get; set; } = Id;

        public int ScreenNumber { get; set; } = ScreenNumber;

        public int Capacity { get; set; } = Capacity;

        public int NumberOfScreenings { get; set; } = screenings.Count();

        public string CreatedAt { get; set; } = created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

    }
}
