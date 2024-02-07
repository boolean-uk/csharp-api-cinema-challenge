using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
   
    public class PMMovie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public double RunTimeMins { get; set; }

    }
}
