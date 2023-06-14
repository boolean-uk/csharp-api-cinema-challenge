namespace BankApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Account account { get; set; }

    }
}
