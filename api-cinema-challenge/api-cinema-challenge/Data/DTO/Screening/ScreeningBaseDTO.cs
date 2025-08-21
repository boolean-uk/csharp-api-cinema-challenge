
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {

    public class ScreeningBaseDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ScreeningBaseDTO(Screening screening) {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            UpdatedAt = screening.UpdatedAt;
        }

        public static List<ScreeningBaseDTO> FromRepository(ICollection<Screening> screenings) {
            List<ScreeningBaseDTO> ret = new List<ScreeningBaseDTO>();
            foreach (Screening screening in screenings)
            {
                ret.Add(new ScreeningBaseDTO(screening));
            }
            return ret;
        }
    }
}

