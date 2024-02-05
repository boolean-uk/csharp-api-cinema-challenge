namespace api_cinema_challenge.Models.DTOs
{
    //DTO
    public class ScreeningResponseDTO
    {
        //public int ID { get; set; }
        public int MovieId { get; set; }
        public int Capacity { get; set; }
        public int Screen { get; set; }
        public DateTime StartTime { get; set; }

        public ScreeningResponseDTO(Screening screening)
        {
            //ID = screening.Id;
            MovieId = screening.MovieId;
            Capacity = screening.Capacity;
            Screen = screening.ScreenNumber;
            StartTime = screening.StartTime;
        }
    }
}
