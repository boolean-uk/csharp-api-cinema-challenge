namespace api_cinema_challenge.Models.DTOs
{
    //DTO
    public class MovieResponseDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Runtime { get; set; }
        public MovieResponseDTO(Movie movie)
        {
            ID = movie.Id;
            Title = movie.Title;
            Runtime = movie.RuntimeMins;
        }
    }
}