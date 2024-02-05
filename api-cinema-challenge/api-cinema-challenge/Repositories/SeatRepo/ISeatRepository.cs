namespace api_cinema_challenge.Repositories.SeatRepo
{
    public interface ISeatRepository
    {
        bool isSeatAvailable(int row, int column);
        void markSeatAsSTaken(int row, int column);
    }
}
