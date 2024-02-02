using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public MovieDTO Movie { get; set; }
        
        public ScreeningDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartTime = screening.StartTime;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
            Movie = new MovieDTO(screening.Movie);
        }

    }
    public class ScreeningResponseDTO{
        public string status { get;}
        public ScreeningDTO data { get; set; }

    
        public ScreeningResponseDTO(string status, Screening data){
            this.status = status;
            this.data = new ScreeningDTO(data);
        }
    }

    public class ScreeningListResponseDTO{
        public string status { get;}
        public List<ScreeningDTO> data { get; set; }

    
        public ScreeningListResponseDTO(string status, IEnumerable<Screening> data){
            this.status = status;
            this.data = new List<ScreeningDTO>();
            foreach (var screening in data){
                this.data.Add(new ScreeningDTO(screening));
            }
        }
    }
}
