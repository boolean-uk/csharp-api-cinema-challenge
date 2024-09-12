using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public ScreeningDTO CreateScreening(int screenNumber, int capacity, DateTime startsAt);
        public List<ScreeningDTO> GetScreenings();
    }
}
