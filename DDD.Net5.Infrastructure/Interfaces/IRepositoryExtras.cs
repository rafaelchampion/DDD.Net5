using DDD.Net5.Domain.Interfaces;
using System.Linq;

namespace DDD.Net5.Infrastructure.Interfaces
{
    public interface IRepositoryBatchOperations<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> BatchAdd(IQueryable<TEntity> entities);
        IQueryable<TEntity> BatchUpdate(IQueryable<TEntity> entities);
        void BatchRemove(IQueryable<TEntity> entities);
    }
}
