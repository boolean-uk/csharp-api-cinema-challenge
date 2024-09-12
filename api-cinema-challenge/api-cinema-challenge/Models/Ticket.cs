using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        private readonly int _id;
        private readonly int _screeningId;
        private readonly DateTime _created;

        internal Ticket(int screeningId)
        {
            if (screeningId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(screeningId));
            }

            Random rnd = new Random();
            this._id = rnd.Next(100000, 999999);
            _screeningId = screeningId;
            this._created = DateTime.Now;
        }

        internal int Id { get { return _id; } }
        internal int ScreeningId {  get { return _screeningId; } }
        internal DateTime Created { get { return _created; } }
    }
}
