using api_cinema_challenge.Data;
using api_cinema_challenge.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _database;
        private DbSet<T> _dbSet;

        public Repository(CinemaContext database)
        {
            _database = database;
            _dbSet = _database.Set<T>();
        }
        public async Task<T> Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _database.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> SelectAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> SelectById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Update(int id, T entity)
        {
            // Find the existing entity by ID
            var existingEntity = await _dbSet.FindAsync(id);
            if(existingEntity == null)
            {
                return null;
            }

            // Update properties of the existing entity with the values from the new entity
            foreach (var property in entity.GetType().GetProperties())
            {
                var newValue = property.GetValue(entity);
                var existingValue = property.GetValue(existingEntity);

                // Check if the value is different before updating
                if ((property.Name != "Id" && property.Name != "CreatedAt") && !object.Equals(newValue, existingValue))
                {
                    property.SetValue(existingEntity, newValue);
                }
                if(property.Name == "UpdatedAt")
                {
                    property.SetValue(existingEntity, DateTime.UtcNow);
                }
                if(property.Name == "CreatedAt")
                {
                    property.SetValue(existingEntity, existingValue);
                }
            }

            // Save changes to the database
            await _database.SaveChangesAsync();

            return existingEntity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _database.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<IEnumerable<T>> SelectWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
