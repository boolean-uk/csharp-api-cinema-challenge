using System.Xml.Linq;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        private readonly int _id;
        private string _title;
        private string _description;
        private string _rating;
        private int _runtimeMins;
        private IEnumerable<Screening> _screenings;
        private readonly DateTime _created;
        private DateTime _updated;

        internal Movie(string title, string description, string rating, int runtimeMins)
        {
            Random rnd = new Random();
            this._id = rnd.Next(100000, 999999);
            _title = title;
            _description = description;
            _rating = rating;
            _runtimeMins = runtimeMins;
            this._screenings = new List<Screening>();
            _created = DateTime.Now;
        }

        internal int Id { get { return _id; } }
        internal string Title { get { return _title; } set { this._title = Title; this._updated = DateTime.Now; } }
        internal string Description { get { return _description; } set { this._description = Description; this._updated = DateTime.Now; } }
        internal string Rating { get { return _rating; } set { this._rating = Rating; this._updated = DateTime.Now; } }
        internal int RuntimeMins { get { return _runtimeMins; } set { this._runtimeMins = RuntimeMins; this._updated = DateTime.Now; } }
        internal IEnumerable<Screening> Screenings { get { return _screenings; } set { this._screenings = Screenings; this._updated = DateTime.Now; } }

        internal DateTime Created { get { return _created; } }
        internal DateTime Updated { get { return _updated; } }


    }
}
