using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;

namespace api_cinema_challenge.Models.DTO
{
    public class DTO
    {
        private DtMovie _movie = new DtMovie();
        private DtScreening _screening = new DtScreening();
        private DtCustomer _customer = new DtCustomer();
        private DtTicket _ticket = new DtTicket();
        private List<DtMovie> _movies = new List<DtMovie>();
        private List<DtScreening> _screenings = new List<DtScreening>();
        private List<DtCustomer> _customers = new List<DtCustomer>();
        private List<DtTicket> _tickets = new List<DtTicket>();
        public DtMovie Movie { get { return _movie; } } 
        public DtCustomer Customer { get { return _customer; } }
        public DtScreening Screening { get { return _screening; } }
        public IEnumerable<DtMovie> Movies { get { return _movies; } }
        public IEnumerable<DtCustomer> Customers { get { return _customers; } }
        public IEnumerable<DtScreening> Screenings { get { return _screenings; } }
        public IEnumerable<DtTicket> Tickets { get { return _tickets; } }
        public DtTicket Ticket { get { return _ticket; } }

        public DtScreening createDtScreening(Screening model) {
            _screening = new DtScreening();
            _screening.ScreenNumber = model.ScreenNumber;
            _screening.Capacity = model.Capacity;
            _screening.StartsAt = model.StartsAt;
            _screening.Id = model.Id;
            _screening.CreatedAt = model.CreatedAt;
            _screening.UpdatedAt = model.UpdatedAt;
            _screenings.Add(_screening);

            return _screening; 
        }
        public DtCustomer createDtCustomer(Customer model) {
            _customer = new DtCustomer();
            _customer.Id = model.Id;
            _customer.Name = model.Name;
            _customer.Phone = model.Phone;
            _customer.Email = model.Email;
            _customer.CreatedAt = model.CreatedAt;
            _customer.UpdatedAt = model.UpdatedAt;  
            _customers.Add(_customer);

            return _customer;
        }
        public DtMovie createDtMovie(Movie model) {
            _movie = new DtMovie();
            _movie.Id = model.Id;
            _movie.Title = model.Title;
            _movie.RunTime = model.RunTime;
            _movie.Rating = model.Rating;
            _movie.Description = model.Description;
            _movie.CreatedAt = model.CreatedAt;
            _movie.UpdatedAt = model.UpdatedAt;
            _movies.Add(_movie);
            return _movie;
        }
        public DtTicket createDtTicket(Ticket model)
        {
            _ticket = new DtTicket();
            _ticket.Id = model.Id;
            _ticket.NumSeats = model.NumSeats;
            _ticket.CreatedAt = model.CreatedAt;
            _ticket.UpdatedAt = model.UpdatedAt;
            _tickets.Add(_ticket);
            return _ticket;
        }
       
    }
}
