namespace api_cinema_challenge.DTO
{
    public record ScreeningPost(int ScreenId, int MovieId, string StartingAt);
    public record ScreeningMoviePost(int ScreenId, string StartingAt);
    public record ScreeningView
    {
        //(int Id, ScreenSimple Screen, IEnumerable<SeatInternal> AvailableSeats, DateTime StartingAt, DateTime CreatedAt, DateTime UpdatedAt)
        public int Id { get; set; }
        public ScreenInternal Screen { get; set; }
        public IEnumerable<SeatInternal> AvailableSeats { get; set; }
        public DateTime StartingAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public record ScreeningViewSeatCount
    {
        //(int Id, ScreenSimple Screen, IEnumerable<SeatInternal> AvailableSeats, DateTime StartingAt, DateTime CreatedAt, DateTime UpdatedAt)
        public int Id { get; set; }
        public ScreenInternal Screen { get; set; }
        public int AvailableSeats { get; set; }
        public DateTime StartingAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public record ScreeningScreen(ScreenInternal Screen, DateTime StartingAt);
    public record ScreeningSimple(DateTime StartingAt);

}
