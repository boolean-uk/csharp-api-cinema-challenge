using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new();
        private List<Movie> _movies = new();
        private List<Screening> _screening = new();


        //random value strings generated with chatgpt:
        private List<string> firstnames = new()
        {
            "John",
            "Jane",
            "Michael",
            "Emily",
            "William",
            "Sophia",
            "James",
            "Olivia",
            "Robert",
            "Emma"
        };

        private List<string> lastnames = new List<string>
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor"
        };

        private List<string> domain = new()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };

        private List<string> movieNamePrefixes = new List<string>
        {
            "The",
            "Return of",
            "Journey to",
            "Rise of",
            "Revenge of",
            "Escape from",
            "Adventures in",
            "Quest for",
            "Invasion of",
            "Attack of"
        };

        private List<string> movieNameAdjectives = new List<string>
        {
            "Brave",
            "Eternal",
            "Mystic",
            "Forgotten",
            "Hidden",
            "Lost",
            "Magical",
            "Forbidden",
            "Enchanted",
            "Legendary"
        };

        private List<string> movieNameNouns = new List<string>
        {
            "Dragon",
            "Hero",
            "Sorcerer",
            "Kingdom",
            "Empire",
            "Crystal",
            "Guardian",
            "Legend",
            "Treasure",
            "Prophecy"
        };

        static Random numRandom = new Random();
        private string generatePhoneNumber()
        { 
            return numRandom.Next(10000000, 100000000).ToString();
        }

        public Seeder() 
        { 
            _customers.Add(new() { });
        }

        
    }
}
