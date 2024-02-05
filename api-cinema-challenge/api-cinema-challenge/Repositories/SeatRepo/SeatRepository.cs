namespace api_cinema_challenge.Repositories.SeatRepo
{
    public class SeatRepository : ISeatRepository
    {
        private bool[,] seatAvailability;

        public SeatRepository(int rows, int column) {
            seatAvailability = new bool[rows, column];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    seatAvailability[i, j] = true;
                }
            }
        }

        public bool isSeatAvailable(int row, int column)
        {
            if (row >= 0 && row < seatAvailability.GetLength(0))
            {
                if (column >= 0 && column < seatAvailability.GetLength(1))
                {
                    if (seatAvailability[row, column] == true) { return true; }
                } else { 
                    return false; 
                }
            } else {
                return false;
            }
            return false;
        }

        public void markSeatAsSTaken(int row, int column)
        {
            if (isSeatAvailable(row, column))
            {
                seatAvailability[row, column] = false;
            }
        }
    }
}
