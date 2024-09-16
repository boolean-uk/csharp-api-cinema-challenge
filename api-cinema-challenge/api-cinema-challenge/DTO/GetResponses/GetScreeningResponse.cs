namespace api_cinema_challenge.DTO.GetResponses
{
    public class GetScreeningResponse
    {
        public ICollection<ScreeningDTO> Screenings { get; set; } = new List<ScreeningDTO>();
    }
}
