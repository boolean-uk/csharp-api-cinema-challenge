﻿using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        // Customer CRUD
        public async Task<Customer> CreateACustomer(Customer entity)
        {
            _db.Customers.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers
                .Include(a => a.Screening)
                .ThenInclude(b => b.Movie)
                .ToListAsync();
        }

        public async Task<Customer> UpdateACustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> DeleteACustomer(int customerId)
        {
            var target = await _db.Customers.FirstOrDefaultAsync(x => x.Id == customerId);

            if (target == null)
                throw new Exception($"Customer with id {customerId} does not exist.");

            _db.Customers.Remove(target);

            await _db.SaveChangesAsync();

            return target;
        }

        // Movies CRUD
        public async Task<Movie> CreateAMovie(Movie entity)
        {
            _db.Movies.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> UpdateAMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> DeleteAMovie(int movieId)
        {
            var target = await _db.Movies.FirstOrDefaultAsync(x => x.Id == movieId);

            if (target == null)
                throw new Exception($"Movie with id {movieId} does not exist.");

            _db.Movies.Remove(target);

            await _db.SaveChangesAsync();

            return target;
        }

        // Screenings
        public async Task<IEnumerable<Screening>> GetAllScreenings(int movieId)
        {
            return await _db.Screenings
                .Where(s => s.MovieID == movieId)
                .Include(a => a.Movie)
                .ToListAsync();
        }

        public async Task<Screening> CreateScreening(Screening entity)
        {
            _db.Screenings.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
