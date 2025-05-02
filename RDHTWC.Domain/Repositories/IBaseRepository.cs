
using RDHTWC.Domain.Base;
using System.Linq.Expressions;

namespace RDHTWC.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<OperationResult> GetAllAsync();
        Task<OperationResult> GetByIdAsync(int id);
        Task<OperationResult> SaveEntityAsync(TEntity entity);
        Task<OperationResult> UpdateEntityAsync(TEntity entity);
        Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter);
    }
}
