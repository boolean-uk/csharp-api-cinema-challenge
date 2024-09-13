namespace api_cinema_challenge.DTO.GetResponses
{
    public class GetMovieResponse
    {
        public ICollection<MovieDTO> Movies { get; set; } = new List<MovieDTO>();

    }
}
