// Data/CustomerSeeder.cs

using System.Linq;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;
public class CustomerSeed
{
    private List<string> _firstNames =
    [
        "John", "Jane", "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona",
        "George", "Hannah", "Ian", "Julia", "Kevin", "Laura", "Mike", "Nina"
    ];

    private List<string> _lastNames =
    [
        "Smith", "Doe", "Johnson", "Brown", "Williams", "Miller", "Davis", "Wilson",
        "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson"
    ];

    private List<string> _domain = new List<string>()
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

    // Builds a deterministic list of customers with unique emails and phone numbers.
    public List<Customer> Get(int take = 10)
    {
        var customers = new List<Customer>(take);
        int id = 1;

        foreach (var first in _firstNames)
        {
            foreach (var last in _lastNames)
            {
                if (customers.Count >= take) return customers;

                var domain = _domain[(id - 1) % _domain.Count];

                customers.Add(new Customer
                {
                    Id = id,
                    Name = first + " " + last,
                    Email = BuildEmail(first, last, id, domain),
                    Phone = BuildPhone(id, domain)
                });

                id++;
            }
        }

        // If 'take' exceeds the name combinations, keep cycling
        while (customers.Count < take)
        {
            var first = _firstNames[(id - 1) % _firstNames.Count];
            var last = _lastNames[(id - 1) % _lastNames.Count];
            var domain = _domain[(id - 1) % _domain.Count];

            customers.Add(new Customer
            {
                Id = id,
                Name = first + " " + last,
                Email = BuildEmail(first, last, id, domain),
                Phone = BuildPhone(id, domain)
            });

            id++;
        }

        return customers;
    }

    private static string BuildEmail(string first, string last, int id, string domain)
    {
        string Slug(string s) => new string(s.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray());
        return $"{Slug(first)}.{Slug(last)}{id}@{domain}";
    }

    private static string BuildPhone(int id, string domain)
    {
        // Map TLD to a country code; default to +47 (Norway)
        var tld = domain.Split('.').Last();
        var cc = tld switch
        {
            "us" => "1",
            "uk" => "44",
            "ca" => "1",
            "gr" => "30",
            "nl" => "31",
            "ru" => "7",
            "com" => "1",
            "org" => "1",
            _ => "47"
        };

        // Deterministic 3-3-4 style digits to ensure uniqueness and validity-like length
        int a = (id * 7919) % 900 + 100; // 3 digits
        int b = (id * 104729) % 900 + 100; // 3 digits
        int c = (id * 13007) % 9000 + 1000; // 4 digits

        return $"+{cc}{a}{b}{c}";
    }
}