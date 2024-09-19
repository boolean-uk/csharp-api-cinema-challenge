using api_cinema_challenge.Models;
using System.ComponentModel;

namespace api_cinema_challenge.ViewModels
{
    public class MovieUPDATEModel
    {
        [DefaultValue("")]
        public string Title { get; set; }
        [DefaultValue("")]
        public string Rating { get; set; }
        [DefaultValue("")]
        public string Description { get; set; }
        [DefaultValue(0)]
        public int RuntimeMins { get; set; }
    }
}
