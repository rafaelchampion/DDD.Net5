using DDD.Net5.Domain.Interfaces;
using System;
using System.Linq;

namespace DDD.Net5.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        TEntity Find(Func<TEntity, bool> predicate);
        IQueryable<TEntity> FindAll(Func<IQueryable<TEntity>> predicate);
    }
}