
namespace api_cinema_challenge.Models
{
    public class Screening
    {
        private int _id;
        private int _screenNumber;
        private int _capacity;
        private DateTime _startsAt;

        internal Screening(int screenNumber, int capacity, DateTime startsAt)
        {
            Random rnd = new Random();
            this._id = rnd.Next(100000, 999999);
            this._screenNumber = screenNumber;
            this._capacity = capacity;
            this._startsAt = startsAt;
        }

        internal int Id { get { return _id; } }
        internal int ScreenNumber { get { return _screenNumber; } }

        internal int Capacity { get { return _capacity; } }

        internal DateTime StartsAt { get { return _startsAt; } }


    }
}
