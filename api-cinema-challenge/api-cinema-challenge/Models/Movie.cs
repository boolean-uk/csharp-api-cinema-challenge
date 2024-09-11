using System.Xml.Linq;

namespace api_cinema_challenge.Models
{
    internal class Movie
    {
        private int _id;
        private string _title;
        private string _description;
        private string _rating;
        private int _runtimeMins;
        private IEnumerable<Screening> _screenings;

        internal Movie(string title, string description, string rating, int runtimeMins)
        {
            Random rnd = new Random();
            this._id = rnd.Next(100000, 999999);
            _title = title;
            _description = description;
            _rating = rating;
            _runtimeMins = runtimeMins;
            this._screenings = new List<Screening>();
        }

        internal int Id { get { return _id; } }
        internal string Title { get { return _title; } set { this._title = Title; } }
        internal string Description { get { return _description; } set { this._description = Description; } }
        internal string Rating { get { return _rating; } set { this._rating = Rating; } }
        internal int RuntimeMins { get { return _runtimeMins; } set { this._runtimeMins = RuntimeMins; } }
        internal IEnumerable<Screening> Screenings { get { return _screenings; } set { this._screenings = Screenings; } }


    }
}
