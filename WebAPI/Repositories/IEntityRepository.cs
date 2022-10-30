using System.Linq.Expressions;
using WebAPI.Entities.abstracts;

namespace WebAPI.Repositories
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] including);
    }
}