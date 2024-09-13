namespace api_cinema_challenge.DTOs
{
    public class DTOScreeningObject
    {
        public int Id { get; set; }
        public int _screenNumber { get; set; }
        public int _capacity { get; set; }
        public DateTime _startsAt { get; set; }
        public  DateTime _created { get; set; }
        public DateTime _updated { get; set; }

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
