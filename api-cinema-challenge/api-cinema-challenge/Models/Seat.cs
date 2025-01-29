using api_cinema_challenge.Enums;

namespace api_cinema_challenge.Models
{
    public class Seat : IEquatable<Seat>
    {
        public int Id { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public SeatType SeatType { get; set; }

        public List<Ticket> Tickets { get; set; } = [];


        public bool Equals(Seat? other)
        {
            return other is not null || (Id == other!.Id && ScreenId == other.ScreenId);
        }
        public override bool Equals(object? obj) => obj is Seat other && Equals(other);
        public override int GetHashCode() => HashCode.Combine(Id, ScreenId);

    }
}
