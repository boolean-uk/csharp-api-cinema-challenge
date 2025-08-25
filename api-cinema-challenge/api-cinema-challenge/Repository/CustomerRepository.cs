using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository;

public class CustomerRepository(CinemaDbContext cinemaDb) : ICustomerRepository
{
    public async Task<IEnumerable<CustomerGetDto>> GetCustomers()
    {
        return await cinemaDb.Customers
            .Select(c => new CustomerGetDto()
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }).ToListAsync();
    }

    public async Task<CustomerGetDto> PostCustomer(CustomerPostDto cpd)
    {
        // Check validate post dto
        if (string.IsNullOrWhiteSpace(cpd.Name) ||
            string.IsNullOrWhiteSpace(cpd.Email) ||
            string.IsNullOrWhiteSpace(cpd.Phone))
        {
            throw new ArgumentException("Invalid customer data.");
        }

        // Check email not already exists
        var existingCustomer = await cinemaDb.Customers
            .FirstOrDefaultAsync(c => c.Email == cpd.Email);

        if (existingCustomer != null)
        {
            throw new ArgumentException("Customer with this email already exists.");
        }

        // TODO: check phone

        // Create new customer
        var c = cinemaDb.Customers.Add(new Customer
        {
            Name = cpd.Name,
            Email = cpd.Email,
            Phone = cpd.Phone,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Tickets = []
        });

        await cinemaDb.SaveChangesAsync();
        return new CustomerGetDto
        {
            Id = c.Entity.Id,
            Name = c.Entity.Name,
            Email = c.Entity.Email,
            Phone = c.Entity.Phone,
            CreatedAt = c.Entity.CreatedAt,
            UpdatedAt = c.Entity.UpdatedAt
        };
    }

    public async Task<CustomerGetDto> UpdateCustomer(int id, CustomerUpdateDto cud)
    {
        var customerToUpdate = await cinemaDb.Customers.FirstOrDefaultAsync(c => c.Id == id);
        
        if (customerToUpdate == null)
        {
            throw new ArgumentException("Customer not found.");
        }

        // Update fields if provided
        if (!string.IsNullOrWhiteSpace(cud.Name))
        {
            customerToUpdate.Name = cud.Name;
        }

        if (!string.IsNullOrWhiteSpace(cud.Email))
        {
            // Check email not already exists
            var existingCustomer = await cinemaDb.Customers
                .FirstOrDefaultAsync(c => c.Email == cud.Email && c.Id != id);

            if (existingCustomer != null)
            {
                throw new ArgumentException("Another customer with this email already exists.");
            }

            customerToUpdate.Email = cud.Email;
        }

        if (!string.IsNullOrWhiteSpace(cud.Phone))
        {
            customerToUpdate.Phone = cud.Phone;
        }
        
        customerToUpdate.UpdatedAt = DateTime.UtcNow;
        
        await cinemaDb.SaveChangesAsync();

        return new CustomerGetDto
        {
            Id = customerToUpdate.Id,
            Name = customerToUpdate.Name,
            Email = customerToUpdate.Email,
            Phone = customerToUpdate.Phone,
            CreatedAt = customerToUpdate.CreatedAt,
            UpdatedAt = customerToUpdate.UpdatedAt
        };
    }

    public async Task<CustomerGetDto> DeleteCustomer(int id)
    {
        var customerToDelete = await cinemaDb.Customers.FirstOrDefaultAsync(c => c.Id == id);
        
        if (customerToDelete == null)
        {
            throw new ArgumentException("Customer not found.");
        }
        
        cinemaDb.Customers.Remove(customerToDelete);
        await cinemaDb.SaveChangesAsync();
        return new CustomerGetDto
        {
            Id = customerToDelete.Id,
            Name = customerToDelete.Name,
            Email = customerToDelete.Email,
            Phone = customerToDelete.Phone,
            CreatedAt = customerToDelete.CreatedAt,
            UpdatedAt = customerToDelete.UpdatedAt
        };
    }

    public async Task<TicketGetDto> BookTicket(int customerId, int screeningId, NumSeatsDto numSeats)
    {
        var customer = await cinemaDb.Customers
            .FirstOrDefaultAsync(c => c.Id == customerId);
        
        if (customer == null)
        {
            throw new ArgumentException("Customer not found.");
        }
        
        var screening = await cinemaDb.Screenings.Include(screening => screening.Tickets).FirstOrDefaultAsync(s => s.Id == screeningId);
        
        if (screening == null)
        {
            throw new ArgumentException("Screening not found.");
        }
        
        if (numSeats.NumSeats <= 0)
        {
            throw new ArgumentException("Number of seats must be greater than zero.");
        }

        if (screening.Tickets != null && screening.Capacity < screening.Tickets.Count + numSeats.NumSeats)
        {
            throw new ArgumentException("Not enough seats available.");
        }
        
        var ticket = cinemaDb.Tickets.Add(new Ticket
        {
            CustomerId = customerId,
            ScreeningId = screeningId,
            NumSeats = numSeats.NumSeats,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        });
        
        
        await cinemaDb.SaveChangesAsync();
        return new TicketGetDto
        {
            Id = ticket.Entity.Id,
            NumSeats = ticket.Entity.NumSeats,
            CreatedAt = ticket.Entity.CreatedAt,
            UpdatedAt = ticket.Entity.UpdatedAt
        };

    }

    public async Task<IEnumerable<TicketGetDto>> GetTickets(int customerId, int screeningId)
    {
        return await cinemaDb.Tickets
            .Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId)
            .Select(t => new TicketGetDto()
            {
                Id = t.Id,
                NumSeats = t.NumSeats,
                CreatedAt = t.CreatedAt,
                UpdatedAt = t.UpdatedAt
            })
            .ToListAsync();
    }
}