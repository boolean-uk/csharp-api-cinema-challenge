using System.Text.Json.Serialization;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api_cinema_challenge.DTO
{

    public class Payload<T,Y>
    {
        public Payload()
        {
        }

        public string Status { get; set; }
        public T Data { get; set; }
    }

}
