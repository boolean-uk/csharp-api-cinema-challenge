using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        /// This class is split in to the repository files "CustomerRepository",
        /// This is done to ensure easy oversight of the functions.

    }
}
