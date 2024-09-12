using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsScreening
{
    public class ScreeningDTO
    {
        public string status {  get; set; }
        public ScreeningData data { get; set; }

        public ScreeningDTO(Screening screening)
        {
            this.status = "success";
            this.data = new ScreeningData(screening);
        }
    }
}
