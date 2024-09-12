using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public ScreeningDTO CreateScreening(int screenNumber, int capacity, DateTime startsAt)
        {
            Screening screening = null;
            _db.Screenings.Add(screening = new Screening() { Id = _db.Screenings.Max(x => x.Id) + 1 ,ScreenNumber = screenNumber, Capacity = capacity, StartsAt = startsAt });
            _db.SaveChanges();
            return screening.MapToDTO();
        }
        public List<ScreeningDTO> GetScreenings()
        {
            return _db.Screenings.ToList().MapListToDTO();
        }
    }
}
