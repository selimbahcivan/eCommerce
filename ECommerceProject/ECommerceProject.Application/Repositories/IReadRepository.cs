using System.Linq.Expressions;
using ECommerceProject.Domain.Common;

namespace ECommerceProject.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool isTracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool isTracking = true);
        Task<T> GetByIdAsync(int id, bool isTracking = true);
    }
}
