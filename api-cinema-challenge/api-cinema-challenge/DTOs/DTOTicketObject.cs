namespace api_cinema_challenge.DTOs
{
    public class DTOTicketObject
    {
        public int Id { get; set; }
        public int _screeningId { get; set; }
        public DateTime _create { get; set; }

        public DTOTicketObject(int id, int screeningId, DateTime create)
        {
            Id = id;
            _screeningId = screeningId;
            _create = create;
        }
    }
}
