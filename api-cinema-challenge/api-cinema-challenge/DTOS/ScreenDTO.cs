namespace api_cinema_challenge.Models.DTOS
{
    internal class ScreenDTO
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public ScreenDTO(Screen screen)
        {
            Id = screen.Id;
            Capacity = screen.Capacity;
        }
    }
}