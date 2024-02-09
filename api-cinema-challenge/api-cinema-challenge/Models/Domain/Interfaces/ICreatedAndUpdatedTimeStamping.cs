using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Interfaces
{
    public interface ICreatedAndUpdatedTimeStamping
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
