using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.PostModels
{
    public class PMScreening
    {
        public int ScreenNumber {  get; set; }
        public int Capacity {  get; set; }
        public string StartsAt { get; set; }

    }
}
