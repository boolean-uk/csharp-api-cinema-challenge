# EPIC: Online Ticket Booking System for Local Cinema

A local cinema wants to allow people to book tickets online to see movies that are being shown in its various screens. These tickets should be delivered to customers via email. The cinema wants to keep a record of their customers and the tickets they purchase as well as offer a regularly updated list of movies for them to choose from. A single screen might show multiple movies a day, and even the same movie at multiple times. The cinema will expand its number of screens in the future, so the potential for growth needs to be accounted for.

## User Stories

1. **Customer Contact Information**
   - *As a customer*, so I can receive my tickets, I want to provide my contact information.

2. **View Movie List**
   - *As a customer*, so I can decide which movie I want to watch, I want to see a list of movies.

3. **Movie Screening Times**
   - *As a customer*, so I can plan, I want to see when movies are screened.

4. **Update Movie List**
   - *As an admin*, so I can manage the movies shown at the cinema, I want to update the list of movies.

5. **Set Screening Schedule**
   - *As an employee*, so I can manage the movies shown on a screen, I want to set a screening schedule.

6. **Record Customer Purchases**
   - *As an admin*, so I can track customer habits, I want to save customer purchases in a record.


  ## Features
 - Customers: CRUD /customers - DONE
- Movies: CRUD /movies - DONE
- Screens: CRUD /screens - DONE
- Screenings: CRUD /screenings
- Bookings: Create / Delete-> /bookings 
	(you should be able to create a new booking where you specify )

		a) the screening, 
		b) the number of tickets, 
		c) for extra challenge a list of seat row + number)
- Optional challenge: Seats: CRUD /seats