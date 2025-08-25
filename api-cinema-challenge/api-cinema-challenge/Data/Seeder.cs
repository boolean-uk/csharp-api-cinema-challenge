using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public class Seeder
{
    public Seeder()
    {
        Movies = MovieSeed.Get();
        Customers = new CustomerSeed().Get(10);
        Screenings = ScreeningSeed.Get();
        Tickets = CreateTickets();
    }

    private List<Ticket> CreateTickets()
    {
        var random = new Random(123);
        const int numTickets = 12;
        
        var results = new List<Ticket>(numTickets);
        for (var i = 0; i < numTickets; i++)
        {
            var screening = Screenings[random.Next(Screenings.Count)];
            var customer = Customers[random.Next(Customers.Count)];

            results.Add(new Ticket
            {
                Id = i + 1,
                NumSeats = random.Next(1, 5),
                ScreeningId = screening.Id,
                CustomerId = customer.Id,
            });
        }

        return results;
    }

    public List<Movie> Movies { get; }
    public List<Screening> Screenings { get; }
    public List<Customer> Customers { get; }
    public List<Ticket> Tickets { get; }
    
}