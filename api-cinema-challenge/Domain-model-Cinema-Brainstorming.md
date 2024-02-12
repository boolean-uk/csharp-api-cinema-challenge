Domain Entities:

Customer:
Properties: Id, CustomerName, EmailAdress, PhoneNumber, CreatedAt, UpdatedAt

Movie:
Properties: MovieId, Title, Rating, Description, RuntimeMins, CreatedAt, UpdatedAt


Screening:
Properties: ScreeningId, ScreenNumber, ScreenCapacity, StartsAt, CreatedAt, UpdatedAt.
Foreign Key: MovieId (relation with Movie)

Ticket:
Properties: TicketId, SeatNumber, CreatedAt, UpdatedAt
Foreign Keys: CustomerId (relation with Customer), ScreeningId (relation with Screening)


Relationships:  

Customer and Ticket:

- Relationship type: One-to-Many (1:N)
- Description: Each customer can purchase multiple tickets, but each ticket belongs to only one customer.
- Foreign Key: CustomerId in the Ticket table references the id column in the Customer table.


Movie and Screening:
- Relationship type: One-to-Many (1:N)
- Description: Each movie can have multiple screenings, but each screening belongs to only one movie.
- Foreign Key: MovieId in the Screening table references the MovieId column in the Movie table.


Screening and Ticket:
- Relationship type: One-to-Many (1:N)
- Description: Each screening can have multiple tickets booked, but each ticket is associated with only one screening.
- Foreign Key: ScreeningId in the Ticket table references the ScreeningId column in the Screening table.






