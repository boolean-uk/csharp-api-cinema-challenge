using System;
using System.Linq.Expressions;
using AutoMapper;

namespace api_cinema_challenge.Repository;

public interface ICinemaRepository<T>
{

    Task<IEnumerable<T>> GetAll();

    Task<T> GetEntityById(int id);
    Task<T> UpdateEntityById(int id, T entity);
    Task<T> CreateEntity(T entity);
    Task<T> DeleteEntityById(int id);
    public bool Exists(Func<T, bool> exist);
    
    



}
