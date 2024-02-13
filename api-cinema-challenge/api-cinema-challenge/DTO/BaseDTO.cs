using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace api_cinema_challenge.DTO
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
