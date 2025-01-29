using System;
using System.Linq.Expressions;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;

namespace api_cinema_challenge.Repository;

public class CinemaRepository<T> : ICinemaRepository<T> where T : class, ICinemaEntities
{

    private CinemaContext _db;
    private DbSet<T> _table;

    public CinemaRepository(CinemaContext context)
    {
        _db = context;
        _table = _db.Set<T>();
    }

   
    public async Task<T> CreateEntity(T entity)
    {
        
        entity.Id = _table.Max(e => e.Id) + 1;
        entity.CreatedAt = DateTime.Now.ToUniversalTime();
        entity.UpdatedAt = DateTime.Now.ToUniversalTime();
        await _table.AddAsync(entity);
        await _db.SaveChangesAsync();
        return await GetEntityById(entity.Id); //Ensures related objects are returned aswell
       
    }

    public async Task<T> DeleteEntityById(int id)
    {
        T entity = await _table.FindAsync(id);
        if (entity != null)
        {
            _table.Remove(entity);
            await _db.SaveChangesAsync();
        }
        
        return entity;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _table.ToListAsync();
    }

    //The use of "lazy loading" enables us to get all relationed entities without include
    public async Task<T> GetEntityById(int id)
    {
        return await _table.FindAsync(id);
    }

    public async Task<T> UpdateEntityById(int id, T entity)
    {
        T entityToUpdate = await _table.FindAsync(id);

        try
        {
            //Updates only fields that are not empty
            entityToUpdate.Update(entity);
            entityToUpdate.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _db.SaveChangesAsync();

            return entityToUpdate;
        }
        catch (Exception)
        {
            return entityToUpdate;
        }
    }

    public bool Exists(Func<T, bool> exist)
    {
        return _table.Any(exist);
    }


}
