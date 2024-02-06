using api_cinema_challenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Data.Seeders
{
    internal static class CustomerSeeder
    {
        private static Random _random = new();

        private static List<string> _names = [
            "George", "Frank", "Elisabeth", "Frank", "Piotr", "David", "Ruben"
        ];

        public static List<Customer> Generate(int amount)
        {
            List<Customer> customers = [];
            for (int i = 0; i <= amount; i++)
            {
                string name = _names[_random.Next(0, _names.Count)];
                Customer customer = new()
                {
                    Id = i+1,
                    CreatedAt = DateTime.Now,
                    Name = name,
                    Email = $"{name}@email.com",
                    Phone = _random.Next(10000000, 99999999).ToString(),
                };
                customers.Add(customer);
            }
            return customers;
        }
    }
}
