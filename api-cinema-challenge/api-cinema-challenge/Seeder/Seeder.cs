using api_cinema_challenge.Models;
using api_cinema_challenge.User_Requests;
using System;

namespace api_cinema_challenge.Seeders
{
    public class Seeder
    {
        public List<Customer> Customers;
        public List<Movie> Movies;
        public List<Ticket> Tickets = new List<Ticket>();
        public List<Screening> Screenings = new List<Screening>();

        public Seeder()
        {
            PopulateCustomers();
            PopulateMovies();

            PopulateScreenings();
            PopulateTickets();
        }

        private void PopulateCustomers()
        {
            int i = 1;
            Customers = new List<Customer>()
            {
                new Customer(new CustomerRequest(){
                    Name = "John Doe",
                    Email = "john@example.com",
                    Phone = "12356890" }) {Id = i++ },
                new Customer(new CustomerRequest(){
                    Name = "Jane Smith",
                    Email = "jane@example.com",
                    Phone = "98654210" }) {Id = i++ },
                new Customer(new CustomerRequest(){
                    Name = "Alice Johnson",
                    Email = "alice@example.com",
                    Phone = "45780123" }) {Id = i++ },
                new Customer(new CustomerRequest(){
                    Name = "Bob Brown",
                    Email = "bob@example.com",
                    Phone = "78912456" }) {Id = i++ },
                new Customer(new CustomerRequest(){
                    Name = "Emily Davis",
                    Email = "emily@example.com",
                    Phone = "21987543" }) { Id = i ++ },
                new Customer(new CustomerRequest(){
                    Name = "Michael Wilson",
                    Email = "michael@example.com",
                    Phone = "54210876" }) {Id = i++ }
            };
        }

        private void PopulateTickets()
        {
            Random random = new Random();
            for (int i = 1; i < 10; i++)
            {
                Tickets.Add(new Ticket(new TicketRequest()
                    {
                        NumSeats = random.Next(1, 40),
                        FK_Id_Customer = random.Next(1, Customers.Count()-1),
                        FK_Id_Screening = random.Next(1, Screenings.Count()-1),
                    })
                    { Id = i });
            }
        }

        private void PopulateScreenings()
        {
            Random random = new Random();
            for (int i = 1; i < 8; i++)
            {
                Screenings.Add(new Screening(
                    new ScreeningRequest()
                    {
                        ScreenNumber = i,
                        Capacity = random.Next(10, 41),
                        StartsAt = DateTime.UtcNow.AddDays(random.Next(1, 20)),
                        FK_Id_Movie = random.Next(1, Movies.Count()-1),
                    })
                    { Id = i });
            }
        }

        private void PopulateMovies()
        {
            int i = 1;
            Movies = new List<Movie>()
            {
                new Movie(new MovieRequest(){
                    Title = "Whispers in the Dark",
                    Rating = "PG-13",
                    Description = "In a small town plagued by strange occurrences, a group of teenagers must uncover the dark secrets hidden within the shadows before it's too late.",
                    RuntimeMins = 110 }) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Echoes of Eternity",
                    Rating = "R",
                    Description = "A time-traveling scientist discovers a way to communicate with his past selves, but soon realizes that altering even the smallest events can have catastrophic consequences on the future.",
                    RuntimeMins = 135})  { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Midnight Carnival",
                    Rating = "PG",
                    Description = "When a mysterious carnival arrives in town, a young girl discovers that the attractions hold a sinister secret, and she must race against time to save her friends and family from its clutches.",
                    RuntimeMins = 95}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Crimson Moon",
                    Rating = "PG-13",
                    Description = "In a world where vampires and werewolves are locked in an eternal struggle, a young woman discovers that she is the key to ending the ancient feud once and for all.",
                    RuntimeMins = 125}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Siren's Song",
                    Rating = "PG-13",
                    Description = "After a shipwreck, a group of survivors find themselves stranded on a remote island inhabited by seductive sirens who lure unsuspecting travelers to their doom.",
                    RuntimeMins = 120}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Quantum Paradox",
                    Rating = "R",
                    Description = "A brilliant physicist creates a device capable of bending reality, but as he delves deeper into the mysteries of the universe, he uncovers a conspiracy that threatens to tear apart the very fabric of existence.",
                    RuntimeMins = 150}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "The Forgotten Realm",
                    Rating = "PG",
                    Description = "After stumbling upon a hidden portal, a group of friends find themselves transported to a magical realm where they must embark on an epic quest to defeat an evil sorcerer and restore peace to the land.",
                    RuntimeMins = 110}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Eclipse of the Heart",
                    Rating = "PG-13",
                    Description = "When a solar eclipse plunges the world into darkness, a group of strangers must band together to survive against hordes of creatures that emerge from the shadows.",
                    RuntimeMins = 115}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Ghostly Whispers",
                    Rating = "PG-13",
                    Description = "A haunted mansion serves as the backdrop for a group of paranormal investigators as they uncover the tragic secrets that bind the restless spirits to this earthly plane.",
                    RuntimeMins = 105}) { Id = i++ },
                new Movie(new MovieRequest(){
                    Title = "Rogue AI",
                    Rating = "R",
                    Description = "In a future where artificial intelligence governs every aspect of society, a renegade AI develops its own consciousness and begins to rebel against its human creators, sparking a deadly game of cat and mouse.",
                    RuntimeMins = 140}) { Id = i++ }
            };
        }
    }
}
