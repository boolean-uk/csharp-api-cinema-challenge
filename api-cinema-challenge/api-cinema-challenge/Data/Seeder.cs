
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        public List<Customer> Customers = new List<Customer>();
        public List<Movie> Movies = new List<Movie>();
        public List<Ticket> Tickets = new List<Ticket>();
        public List<Screening> Screenings = new List<Screening>();

        public Seeder()
        {
            //PopulateCustomers();
           // PopulateMovies();
          //  PopulateScreenings();
         //   PopulateTickets();
        }

        private void PopulateTickets()
        {
            throw new NotImplementedException();
        }

        private void PopulateScreenings()
        {
            throw new NotImplementedException();
        }

        private void PopulateMovies()
        {
            throw new NotImplementedException();
        }

        private void PopulateCustomers()
        {
        }
    }
}
