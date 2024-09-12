using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public static class Mapper
    {
        public static ResponseCustomerDTO MapToDTO(Customer customer)
        {
            ResponseCustomerDTO responseCustomer = new ResponseCustomerDTO();
            responseCustomer.Id = customer.Id;
            responseCustomer.Name = customer.Name;
            responseCustomer.Email = customer.Email;
            responseCustomer.Phone = customer.Phone;
            responseCustomer.CreatedAt = customer.CreatedAt;
            responseCustomer.UpdatedAt = customer.UpdatedAt;

            foreach (Ticket t in customer.Tickets)
            {
                ResponseTicketDTOCustomerLess responseTicket = new ResponseTicketDTOCustomerLess();
                responseTicket.Id = t.Id;
                responseTicket.NumSeats = t.NumSeats;
                responseTicket.ScreenNumber = t.Screening.ScreenNumber;
                responseTicket.ScreeningStartsAt = t.Screening.StartsAt;
                responseTicket.MovieTitle = t.Screening.Movie.Title;
                responseTicket.CreatedAt = t.CreatedAt;
                responseTicket.UpdatedAt = t.UpdatedAt;

                responseCustomer.Tickets.Add(responseTicket);
            }

            return responseCustomer;
        }
    }
}
