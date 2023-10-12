namespace api_cinema_challenge.Models.Screen
{
    public class ScreenCollectionCreate
    {
        public string status { get; set; } = "success";
        public IEnumerable<Screen> data { get; set; }
    }
}
