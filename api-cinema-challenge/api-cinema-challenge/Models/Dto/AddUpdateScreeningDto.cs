namespace api_cinema_challenge.Models.Dto
{
    public class AddUpdateScreeningDto
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt {  get; set; }
    }
}
