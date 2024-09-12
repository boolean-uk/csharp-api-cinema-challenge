using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class DTOMovieObject
    {
            
        private readonly int _id;
        private string _title;
        private string _description;
        private string _rating;
        private int _runtimeMins;
        private IEnumerable<Screening> _screenings;
        private readonly DateTime _created;
        private DateTime _updated;

        public DTOMovieObject(int id, string title, string description, string rating, int runtimeMins, IEnumerable<Screening> screenings, DateTime created, DateTime updated)
        {
            _id = id;
            _title = title;
            _description = description;
            _rating = rating;
            _runtimeMins = runtimeMins;
            _screenings = screenings;
            _created = created;
            _updated = updated;
        }
    }
}
