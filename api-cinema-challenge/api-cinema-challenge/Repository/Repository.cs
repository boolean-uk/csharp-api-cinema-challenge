using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using System.Collections;
using api_cinema_challenge.Models;


namespace api_cinema_challenge.Repository
{
public class Repository:IRepository
{
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }

        // TODO: - extra 1: save temporary list in Repository of all movies, screenings, Customer, Ticket when updating a table to minimize the time needed to get all elements from a list. And to do the fetch async in the background. 
       // TODO: - exttra 2: Test the effect by getting the GetAllMovies from list in repository and get from db with timestamps.
       





}
}