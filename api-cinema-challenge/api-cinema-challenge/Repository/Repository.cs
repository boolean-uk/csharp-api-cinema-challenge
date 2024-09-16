using api_cinema_challenge.Data;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }
    }
}
