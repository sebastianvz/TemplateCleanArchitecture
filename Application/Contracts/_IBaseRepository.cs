using System;
using System.Linq.Expressions;

namespace Application.Contracts
{
	public interface IBaseRepository<TEntity>
    {
        TEntity GetByID(object id);
        void Delete(object id);
        void Update(TEntity entityToUpdate);
        void Insert(TEntity entity);
        int SaveChanges();
        IEnumerable<TEntity> Get(
    Expression<Func<TEntity, bool>> filter = null,
    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
    string includeProperties = "");
    }
}

