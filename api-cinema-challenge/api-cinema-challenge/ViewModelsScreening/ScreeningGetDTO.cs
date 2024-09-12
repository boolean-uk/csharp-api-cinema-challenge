using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsScreening
{
    public class ScreeningGetDTO
    {
        public string status { get; set; }
        public List<ScreeningData> data { get; set; } = new List<ScreeningData>();

        public ScreeningGetDTO(List<Screening> screenings)
        {
            this.status = "success";
            foreach (var screening in screenings)
            {
                this.data.Add(new ScreeningData(screening));
            }
        }
    }
}
