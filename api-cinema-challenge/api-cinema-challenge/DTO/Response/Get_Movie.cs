using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTO.Response
{
    public class Get_Movie : DTO_Response<Get_Movie, Movies>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();

        public override void Initialize(Movies model)
        {
            Id          = model.Id;
            Title       = model.Title;
            Rating      = model.Rating;
            Description = model.Description;
            RuntimeMins = model.RuntimeMins;
            CreatedAt = model.CreatedAt;
            UpdatedAt = model.UpdatedAt;
        }
    }
}
