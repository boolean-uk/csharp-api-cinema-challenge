using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public List<CustomerBookingDTO> Bookings { get; set; } = new List<CustomerBookingDTO>();


        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;

            foreach (Booking b in customer.Bookings)
            {
                Bookings.Add(new CustomerBookingDTO(b));
            }
        }

        static public List<CustomerDTO> FromListOfCustomers(List<Customer> listCustomer)
        {
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            foreach (var customer in listCustomer)
            {
                customerDTOs.Add(new CustomerDTO(customer));
            }
            return customerDTOs;
        }
    }



    public class CustomerBookingDTO
    {
        public int Id { get; set; }
        public string? FilmTitle { get; set; }
        public TimeOnly? RunTime { get; set; }
        public DateTime Time { get; set; }
        public List<TicketDTO> tickets { get; set; } = new List<TicketDTO>();

        public CustomerBookingDTO(Booking booking)
        {

            Id = booking.Id;
            if (booking.tickets.Any()) {
                FilmTitle = booking.tickets.FirstOrDefault().screening.Movie.Title;
                RunTime = TimeOnly.FromDateTime(booking.tickets.FirstOrDefault().screening.Movie.Runtime);
            }
            
            

            foreach (Ticket t in booking.tickets)
            {
                tickets.Add(new TicketDTO(t));
            }

        }


    }

    public class TicketDTO
    {
         public int ticketId {  get; set; }
        public int seatNumber { get; set; }
        public int rowNumber { get; set; }



        public TicketDTO(Ticket t)
        {
            this.ticketId = t.Id;
            this.seatNumber = t.seat.seatNumber;
            this.rowNumber = t.seat.rowNumber;
        }
    }
}