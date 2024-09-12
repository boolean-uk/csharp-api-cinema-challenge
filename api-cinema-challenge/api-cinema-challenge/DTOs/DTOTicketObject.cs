namespace api_cinema_challenge.DTOs
{
    public class DTOTicketObject
    {
        private readonly int _id;
        private readonly int _screeningId;
        private readonly DateTime _create;

        public DTOTicketObject (int id, int screeningId, DateTime create)
        {
            _id = id;
            _screeningId = screeningId;
            _create = create;
        }
    }
}
