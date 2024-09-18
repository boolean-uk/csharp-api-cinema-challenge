using System.ComponentModel;

namespace api_cinema_challenge.ViewModels
{
    public class CustomerPUTModel
    {
        [DefaultValue("")]
        public string? Name { get; set; } = string.Empty;
        [DefaultValue("")]
        public string? Email { get; set; } = string.Empty;
        [DefaultValue("")]
        public string? Phone { get; set; } = string.Empty;
    }
}
