using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public Payload<ScreeningDTO> CreateScreening();
        public Payload<ScreeningDTO> GetScreenings();
    }
}
