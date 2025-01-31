using System;
using System.Linq.Expressions;
using api_cinema_challenge.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly CinemaContext _context;
    private DbSet<T> _entities;

    public Repository(CinemaContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }
    
    public async Task<IEnumerable<T>> GetAll()
    {
        return await _entities.ToListAsync() ?? throw new KeyNotFoundException("No data found");
    }

    public async Task<IEnumerable<T>> GetAllFilter(Expression<Func<T, bool>> filter)
    {
        return await _entities.Where(filter).ToListAsync() ?? throw new KeyNotFoundException("No data found");
    }

    public async Task<T> GetById(int id)
    {
        return await _entities.FindAsync(id) ?? throw new KeyNotFoundException($"No entity with id {id} found");
    }

    public async Task<T> Create(T entity)
    {
        _entities.Add(entity);
        await Save();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _entities.Update(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await Save();
        return entity;
    }
 
    public async Task<T> Delete(int id)
    {
        var entity =  GetById(id).Result;
        _entities.Remove(entity);
        await Save();
        return entity;
    }

    public async Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _entities;
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.ToListAsync();
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}

