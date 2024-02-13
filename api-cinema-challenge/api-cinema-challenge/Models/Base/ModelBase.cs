namespace api_cinema_challenge.Models.Base
{
    public abstract class ModelBase
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ModelBase()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
