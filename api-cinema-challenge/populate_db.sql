-- Ensure tables are empty before inserting data
TRUNCATE TABLE tickets, screenings, movies, customers RESTART IDENTITY CASCADE;

-- Populating movies table with created_at and updated_at values
INSERT INTO movies (id, title, rating, description, runtime_mins, created_at, updated_at) 
VALUES
(1, 'The Matrix', 'PG-13', 'A computer hacker learns about the true nature of reality.', 120, NOW(), NOW()),
(2, 'The Matrix Reloaded', 'R', 'The second installment of the Matrix trilogy.', 138, NOW(), NOW()),
(3, 'The Matrix Revolutions', 'R', 'The final installment of the Matrix trilogy.', 129, NOW(), NOW());

-- Populating screenings table with correct foreign keys
INSERT INTO screenings (id, starts_at, movie_id, screen_number, capacity, created_at, updated_at)
VALUES
(1, '2025-01-31 09:48:29.054453+00', 1, 1, 40, NOW(), NOW()), 
(2, '2025-01-31 11:48:29.054453+00', 2, 1, 40, NOW(), NOW()), 
(3, '2025-01-31 13:48:29.054453+00', 3, 1, 40, NOW(), NOW());

-- Populating customers table with created_at and updated_at values
INSERT INTO customers (id, name, email, phone, created_at, updated_at)
VALUES
(1, 'Alice', 'alice@example.com', '1234567890', NOW(), NOW()), 
(2, 'Bob', 'bob@example.com', '0987654321', NOW(), NOW());

-- Populating tickets table with correct foreign keys
INSERT INTO tickets (id, num_seats, screening_id, customer_id, created_at, updated_at)
VALUES
(1, 2, 1, 1, NOW(), NOW()), 
(2, 3, 2, 1, NOW(), NOW()), 
(3, 1, 3, 2, NOW(), NOW()), 
(4, 4, 3, 2, NOW(), NOW());
