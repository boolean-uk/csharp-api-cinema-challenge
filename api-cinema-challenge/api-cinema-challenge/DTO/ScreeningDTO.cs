namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int id {  get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
       
    }
}
