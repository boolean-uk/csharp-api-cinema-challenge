namespace api_cinema_challenge.DTO
{
    public interface IBaseDto
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
