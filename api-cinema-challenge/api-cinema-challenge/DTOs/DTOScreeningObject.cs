namespace api_cinema_challenge.DTOs
{
    public class DTOScreeningObject
    {
        private int Id;
        private int _screenNumber;
        private int _capacity;
        private DateTime _startsAt;
        private readonly DateTime _created;
        private DateTime _updated;

        public DTOScreeningObject(int id, int screenNumber, int capacity, DateTime startsAt, DateTime created, DateTime updated)
        {
            Id = id;
            _screenNumber = screenNumber;
            _capacity = capacity;
            _startsAt = startsAt;
            _created = created;
            _updated = updated;

        }
    }
}
